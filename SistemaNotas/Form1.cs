using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.MySqlClient;



namespace SistemaNotas
{
    public partial class Form1 : Form
    {
        private DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            lbl_Aluno = new Label();
            lbl_Disciplina = new Label();
            lbl_Valor = new Label();
            lbl_Data = new Label();
            txtBox_Valor = new TextBox();
            txtBox_Disciplina = new TextBox();
            txtBox_Aluno = new TextBox();
            display_dados = new DataGridView();
            bt_Add = new Button();
            bt_Atualizar = new Button();
            bt_Buscar = new Button();
            bt_Exluir = new Button();
            dateTimePicker = new DateTimePicker();
            txtBox_Id = new TextBox();
            lbl_Id = new Label();
            button1 = new Button();
            button2 = new Button();
            ((ISupportInitialize)display_dados).BeginInit();
            SuspendLayout();
            // 
            // lbl_Aluno
            // 
            lbl_Aluno.AutoSize = true;
            lbl_Aluno.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lbl_Aluno.Location = new Point(27, 62);
            lbl_Aluno.Name = "lbl_Aluno";
            lbl_Aluno.Size = new Size(48, 16);
            lbl_Aluno.TabIndex = 1;
            lbl_Aluno.Text = "Aluno:";
            // 
            // lbl_Disciplina
            // 
            lbl_Disciplina.AutoSize = true;
            lbl_Disciplina.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lbl_Disciplina.Location = new Point(27, 100);
            lbl_Disciplina.Name = "lbl_Disciplina";
            lbl_Disciplina.Size = new Size(73, 16);
            lbl_Disciplina.TabIndex = 2;
            lbl_Disciplina.Text = "Disciplina:";
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lbl_Valor.Location = new Point(27, 141);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(44, 16);
            lbl_Valor.TabIndex = 3;
            lbl_Valor.Text = "Valor:";
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lbl_Data.Location = new Point(27, 178);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(143, 16);
            lbl_Data.TabIndex = 4;
            lbl_Data.Text = "Data de Lançamento:";
            lbl_Data.Click += label5_Click;
            // 
            // txtBox_Valor
            // 
            txtBox_Valor.Location = new Point(130, 134);
            txtBox_Valor.Name = "txtBox_Valor";
            txtBox_Valor.Size = new Size(221, 23);
            txtBox_Valor.TabIndex = 7;
            // 
            // txtBox_Disciplina
            // 
            txtBox_Disciplina.Location = new Point(130, 93);
            txtBox_Disciplina.Name = "txtBox_Disciplina";
            txtBox_Disciplina.Size = new Size(221, 23);
            txtBox_Disciplina.TabIndex = 8;
            // 
            // txtBox_Aluno
            // 
            txtBox_Aluno.Location = new Point(130, 55);
            txtBox_Aluno.Name = "txtBox_Aluno";
            txtBox_Aluno.Size = new Size(221, 23);
            txtBox_Aluno.TabIndex = 9;
            txtBox_Aluno.TextChanged += textBox4_TextChanged;
            // 
            // display_dados
            // 
            display_dados.AllowUserToAddRows = false;
            display_dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            display_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            display_dados.GridColor = SystemColors.ScrollBar;
            display_dados.Location = new Point(368, 25);
            display_dados.Name = "display_dados";
            display_dados.Size = new Size(564, 169);
            display_dados.TabIndex = 12;
            display_dados.CellContentClick += display_dados_CellContentClick;
            // 
            // bt_Add
            // 
            bt_Add.Location = new Point(30, 215);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new Size(78, 23);
            bt_Add.TabIndex = 13;
            bt_Add.Text = "Adicionar";
            bt_Add.UseVisualStyleBackColor = true;
            bt_Add.Click += button1_Click_1;
            // 
            // bt_Atualizar
            // 
            bt_Atualizar.Location = new Point(111, 215);
            bt_Atualizar.Name = "bt_Atualizar";
            bt_Atualizar.Size = new Size(78, 23);
            bt_Atualizar.TabIndex = 14;
            bt_Atualizar.Text = "Atualizar";
            bt_Atualizar.UseVisualStyleBackColor = true;
            bt_Atualizar.Click += button2_Click;
            // 
            // bt_Buscar
            // 
            bt_Buscar.Location = new Point(834, 215);
            bt_Buscar.Name = "bt_Buscar";
            bt_Buscar.Size = new Size(98, 23);
            bt_Buscar.TabIndex = 15;
            bt_Buscar.Text = "Buscar";
            bt_Buscar.UseVisualStyleBackColor = true;
            bt_Buscar.Click += button3_Click;
            // 
            // bt_Exluir
            // 
            bt_Exluir.Location = new Point(192, 215);
            bt_Exluir.Name = "bt_Exluir";
            bt_Exluir.Size = new Size(78, 23);
            bt_Exluir.TabIndex = 16;
            bt_Exluir.Text = "Excluir";
            bt_Exluir.UseVisualStyleBackColor = true;
            bt_Exluir.Click += bt_Exluir_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(187, 171);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(162, 23);
            dateTimePicker.TabIndex = 0;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // txtBox_Id
            // 
            txtBox_Id.Location = new Point(652, 215);
            txtBox_Id.Name = "txtBox_Id";
            txtBox_Id.Size = new Size(176, 23);
            txtBox_Id.TabIndex = 17;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lbl_Id.Location = new Point(623, 218);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(23, 16);
            lbl_Id.TabIndex = 18;
            lbl_Id.Text = "Id:";
            lbl_Id.Click += label1_Click_2;
            // 
            // button1
            // 
            button1.Location = new Point(288, 25);
            button1.Name = "button1";
            button1.Size = new Size(61, 24);
            button1.TabIndex = 19;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(273, 215);
            button2.Name = "button2";
            button2.Size = new Size(76, 23);
            button2.TabIndex = 20;
            button2.Text = "Listar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            ClientSize = new Size(972, 315);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_Id);
            Controls.Add(txtBox_Id);
            Controls.Add(dateTimePicker);
            Controls.Add(bt_Exluir);
            Controls.Add(bt_Buscar);
            Controls.Add(bt_Atualizar);
            Controls.Add(bt_Add);
            Controls.Add(display_dados);
            Controls.Add(txtBox_Aluno);
            Controls.Add(txtBox_Disciplina);
            Controls.Add(txtBox_Valor);
            Controls.Add(lbl_Data);
            Controls.Add(lbl_Valor);
            Controls.Add(lbl_Disciplina);
            Controls.Add(lbl_Aluno);
            Name = "Form1";
            Load += Form1_Load_1;
            ((ISupportInitialize)display_dados).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtBox_Id.Text))
                {
                    CadastroNotas cadastroNotas = new CadastroNotas();

                    if (int.TryParse(txtBox_Id.Text, out int id))
                    {
                        cadastroNotas.Id = id;
                    }
                    else
                    {
                        MessageBox.Show("O ID precisa ser um número válido.");
                        return;
                    }

                    using (MySqlDataReader reader = cadastroNotas.localizarNota())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            reader.Read();
                            txtBox_Id.Text = reader["id"].ToString();
                            txtBox_Aluno.Text = reader["aluno"].ToString();
                            txtBox_Disciplina.Text = reader["disciplina"].ToString();
                            txtBox_Valor.Text = Convert.ToDouble(reader["valor"]).ToString("0.00");
                            dateTimePicker.Value = Convert.ToDateTime(reader["dataLancamento"]);
                        }
                        else
                        {
                            MessageBox.Show("Nota não encontrada");
                            LimparCampos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo ID para realizar a busca.");
                    LimparCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar Nota: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtBox_Id.Clear();
            txtBox_Aluno.Clear();
            txtBox_Disciplina.Clear();
            txtBox_Valor.Clear();
            txtBox_Aluno.Focus();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtBox_Aluno.Text) && !string.IsNullOrWhiteSpace(txtBox_Disciplina.Text) && double.TryParse(txtBox_Valor.Text, out double valor) && dateTimePicker.Value != DateTime.MinValue)
                {

                    CadastroNotas cadNotas = new CadastroNotas();
                    cadNotas.Aluno = txtBox_Aluno.Text;
                    cadNotas.Disciplina = txtBox_Disciplina.Text;
                    cadNotas.DataLancamento = dateTimePicker.Value;

                    if (double.TryParse(txtBox_Valor.Text, out double nota))
                    {
                        cadNotas.Valor = nota;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um valor numérico válido para a nota.");
                        return;
                    }


                    if (cadNotas.cadastrarNotas())
                    {
                        MessageBox.Show($"Nota do Aluno(a) {cadNotas.Aluno} foi cadastrada com sucesso");
                        txtBox_Id.Clear();
                        txtBox_Aluno.Clear();
                        txtBox_Disciplina.Clear();
                        txtBox_Valor.Clear();
                        txtBox_Aluno.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar Nota");
                    }

                }
                else
                {
                    MessageBox.Show("Favor preecher todos os campos corretamente ");
                    txtBox_Id.Clear();
                    txtBox_Aluno.Clear();
                    txtBox_Disciplina.Clear();
                    txtBox_Valor.Clear();
                    txtBox_Aluno.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar Nota" + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtBox_Aluno.Text) && !string.IsNullOrWhiteSpace(txtBox_Disciplina.Text) && double.TryParse(txtBox_Valor.Text, out double valor) && dateTimePicker.Value != DateTime.MinValue)
                {
                    CadastroNotas cadastroNotas = new CadastroNotas();

                    cadastroNotas.Id = int.Parse(txtBox_Id.Text);
                    cadastroNotas.Aluno = txtBox_Aluno.Text;
                    cadastroNotas.Disciplina = txtBox_Disciplina.Text;
                    cadastroNotas.Valor = double.Parse(txtBox_Valor.Text);
                    cadastroNotas.DataLancamento = dateTimePicker.Value;

                    bool sucesso = cadastroNotas.atualizarNota();
                    if (sucesso)
                    {
                        MessageBox.Show("Nota atualizada com sucesso!");
                        LimparCampos();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações");
                        LimparCampos();

                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar a Nota que deseja atualizar as informações");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
            }
        }


        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void bt_Exluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtBox_Aluno.Text) && !string.IsNullOrWhiteSpace(txtBox_Disciplina.Text) && double.TryParse(txtBox_Valor.Text, out double valor) && dateTimePicker.Value != DateTime.MinValue)
                {
                    CadastroNotas cadastroNotas = new CadastroNotas();

                    cadastroNotas.Id = int.Parse(txtBox_Id.Text);

                    bool sucesso = cadastroNotas.deletarNota();
                    if (sucesso)
                    {
                        MessageBox.Show("Nota deletada com sucesso!");
                        LimparCampos();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível deletar a Nota");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar a Nota que deseja exluir");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exluir dados: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ListarNotas();
        }

        private void display_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void ListarNotas()
        {
            try
            {
                CadastroNotas cadastroNotas = new CadastroNotas();
                DataTable dt = cadastroNotas.ListarTodasNotas();

                if (dt != null)
                {
                    display_dados.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhuma nota encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar notas: " + ex.Message);
            }
        }

    }
}