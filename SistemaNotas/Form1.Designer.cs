namespace SistemaNotas
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private Label lbl_Aluno;
        private Label lbl_Disciplina;
        private Label lbl_Valor;
        private Label lbl_Data;
        private TextBox txtBox_Valor;
        private TextBox txtBox_Disciplina;
        private TextBox txtBox_Aluno;
        private DataGridView display_dados;
        private Button bt_Add;
        private Button bt_Atualizar;
        private Button bt_Buscar;
        private Button bt_Exluir;
        private DateTimePicker dateTimePicker;
        private TextBox txtBox_Id;
        private Label lbl_Id;
        private Button button1;
        private Button button2;
    }
}