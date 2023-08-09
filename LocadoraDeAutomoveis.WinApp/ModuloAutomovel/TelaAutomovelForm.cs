using FluentResults;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;

namespace LocadoraDeAutomoveis.WinApp.ModuloAutomovel
{
    public partial class TelaAutomovelForm : Form
    {
        private Automovel automovel { get; set; }

        public event GravarEntidadeDelegate<Automovel> onGravarRegistro;
        public TelaAutomovelForm(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarListas(repositorioGrupoDeAutomoveis);
        }

        public Automovel Automovel
        {
            get
            {
                return automovel;
            }
            set
            {
                ConfigurarAutomovel(automovel);
            }
        }

        public void ConfigurarAutomovel(Automovel automovel)
        {
            this.automovel = automovel;
            listGrupoDeAutomoveis.SelectedItem = automovel.GrupoDeAutomoveis;
            listTipoDeCombustivel.SelectedItem = automovel.TipoDeCombustivel;
            txtMarca.Text = automovel.Marca;
            txtModelo.Text = automovel.Modelo;
            txtCor.Text = automovel.Cor;
            if (automovel.Ano != DateTime.MinValue)
                datePickerAnoDoCarro.Value = automovel.Ano;
            txtPlaca.Text = automovel.Placa;
            nmrCapacidadeEmLitros.Value = automovel.CapacidadeEmLitros;

            Image foto = null;
            foto = ConverterByteEmImagem(automovel, foto);
            pickBoxFotoAutomovel.Image = foto;
        }
        public Automovel ObterAutomovel()
        {

            automovel.Modelo = txtModelo.Text;
            automovel.Marca = txtMarca.Text;
            automovel.Cor = txtCor.Text;
            automovel.Placa = txtPlaca.Text;
            automovel.Ano = datePickerAnoDoCarro.Value;
            automovel.CapacidadeEmLitros = (int)nmrCapacidadeEmLitros.Value;
            automovel.TipoDeCombustivel = (TipoDeCombustivelEnum)listTipoDeCombustivel.SelectedItem;
            automovel.GrupoDeAutomoveis = (GrupoDeAutomoveis)listGrupoDeAutomoveis.SelectedItem;

            byte[] foto = null;
            foto = ConverterImagemParaByte(foto);
            automovel.Foto = foto;

            return automovel;
        }





















        private void ConfigurarListas(IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis)
        {
            foreach (var grupo in repositorioGrupoDeAutomoveis.RetornarTodos())
            {
                listGrupoDeAutomoveis.Items.Add(grupo);
            }
            listTipoDeCombustivel.Items.Add(TipoDeCombustivelEnum.Gas);
            listTipoDeCombustivel.Items.Add(TipoDeCombustivelEnum.Alcool);
            listTipoDeCombustivel.Items.Add(TipoDeCombustivelEnum.Diesel);
            listTipoDeCombustivel.Items.Add(TipoDeCombustivelEnum.Gasolina);
        }
        private byte[] ConverterImagemParaByte(byte[] foto)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        if (pickBoxFotoAutomovel.Image != null)
                        {
                            pickBoxFotoAutomovel.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            foto = ms.ToArray();
                        }
                        else
                            throw new Exception();
                    }
                    catch (Exception ex) 
                    { 
                        MessageBox.Show("Insira uma imagem"); 
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imagem invalida");
            }

            return foto;
        }

        private void pickBoxFotoAutomovel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Selecione uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                Image imagem = Image.FromFile(caminhoDaImagem);
                pickBoxFotoAutomovel.Image = imagem;
            }
        }
        public static Image ConverterByteEmImagem(Automovel automovel, Image foto)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(automovel.Foto))
                {
                    foto = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {

            }

            return foto;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            automovel = ObterAutomovel();

            Result resultado = onGravarRegistro(automovel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipal.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

    }
}
