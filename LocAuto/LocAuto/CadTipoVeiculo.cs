﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaoMysql;
using Modelo;
using Services;
using DaoInterface;

namespace LocAuto
{
    public partial class CadTipoVeiculo : Form
    {
        public TipoVeiculo tipoVeiculoConsulta { get; set; }

        public CadTipoVeiculo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TipoVeiculo tipoVeiculo = new TipoVeiculo();
            TipoVeiculoDAO tipoVeiculoDao = new TipoVeiculoDAO();
            TipoVeiculoService tipoVeiculoService = new TipoVeiculoService(tipoVeiculoDao);

            if (!String.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                tipoVeiculo.Codigo = Convert.ToInt32(TxtCodigo.Text);
            }
            
            tipoVeiculo.Descricao = TxtGrupo.Text;
            tipoVeiculo.ArCondicionado = ChkArCondicionado.Checked.ToString();
            tipoVeiculo.VidroEletrico = ChkVidroEletrico.Checked.ToString();
            tipoVeiculo.TravaEletrica = ChkTravaEletrica.Checked.ToString();
            tipoVeiculo.Abs = ChkAbs.Checked.ToString();
            tipoVeiculo.AirBag = ChkAirBag.Checked.ToString();
            if (!String.IsNullOrWhiteSpace(TxtValorDiaria.Text))
            {
                tipoVeiculo.ValorDiaria = Convert.ToDecimal(TxtValorDiaria.Text);
            }            

            try
            {
                if (tipoVeiculo.Codigo == 0)
                {
                    tipoVeiculoService.inserir(tipoVeiculo);
                }
                else
                {
                    tipoVeiculoService.atualizar(tipoVeiculo);
                }
                MessageBox.Show("Cadastro salvo com sucesso!");
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Mensagem");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }

        private void LimparTxt()
        {
            TxtGrupo.Text = "";
            ChkArCondicionado.Checked = false;
            ChkVidroEletrico.Checked = false;
            ChkTravaEletrica.Checked = false;
            ChkAbs.Checked = false;
            ChkAirBag.Checked = false;
            TxtValorDiaria.Text = "";
        }

        private void CadTipoVeiculo_Load(object sender, EventArgs e)
        {
            if (tipoVeiculoConsulta != null)
            {
                TxtCodigo.Text = tipoVeiculoConsulta.Codigo.ToString();
                TxtGrupo.Text = tipoVeiculoConsulta.Descricao;

                if (tipoVeiculoConsulta.Abs == "True")
                {
                    ChkAbs.Checked = true;
                }else
                {
                    ChkAbs.Checked = false;
                }

                if (tipoVeiculoConsulta.AirBag == "True")
                {
                    ChkAirBag.Checked = true;
                }else
                {
                    ChkAirBag.Checked = false;
                }
                
                if (tipoVeiculoConsulta.ArCondicionado == "True")
                {
                    ChkArCondicionado.Checked = true;
                }else
                {
                    ChkArCondicionado.Checked = false;
                }

                if(tipoVeiculoConsulta.TravaEletrica == "True")
                {
                    ChkTravaEletrica.Checked = true;
                }else
                {
                    ChkTravaEletrica.Checked = false;
                }

                if(tipoVeiculoConsulta.VidroEletrico == "True")
                {
                    ChkVidroEletrico.Checked = true;
                }else
                {
                    ChkVidroEletrico.Checked = false;
                }

                TxtValorDiaria.Text = tipoVeiculoConsulta.ValorDiaria.ToString();
            }
        }

        private void TxtValorDiaria_Validated(object sender, EventArgs e)
        {
            if (!Validador.eDecimal(TxtValorDiaria.Text))
            {
                MessageBox.Show(Validador.msgDecimal, "Validação de campo");
                TxtValorDiaria.Text = "";
                TxtValorDiaria.Focus();
            }
        }
    }
}
