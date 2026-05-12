namespace WinFormsApp1
{
    partial class JogosDB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JogosGridView = new DataGridView();
            TxtJogo = new TextBox();
            TxtDesc = new RichTextBox();
            TxtTema = new ComboBox();
            TxtFaixaEt = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnCadastrar = new Button();
            BtnAtualizar = new Button();
            BtnDeletar = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)JogosGridView).BeginInit();
            SuspendLayout();
            // 
            // JogosGridView
            // 
            JogosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            JogosGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            JogosGridView.BackgroundColor = SystemColors.ControlLight;
            JogosGridView.BorderStyle = BorderStyle.Fixed3D;
            JogosGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JogosGridView.Location = new Point(395, 22);
            JogosGridView.Name = "JogosGridView";
            JogosGridView.ReadOnly = true;
            JogosGridView.RowHeadersWidth = 51;
            JogosGridView.Size = new Size(760, 328);
            JogosGridView.TabIndex = 0;
            // 
            // TxtJogo
            // 
            TxtJogo.Cursor = Cursors.IBeam;
            TxtJogo.Location = new Point(12, 70);
            TxtJogo.Name = "TxtJogo";
            TxtJogo.Size = new Size(125, 27);
            TxtJogo.TabIndex = 1;
            // 
            // TxtDesc
            // 
            TxtDesc.Cursor = Cursors.IBeam;
            TxtDesc.Location = new Point(12, 141);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.Size = new Size(210, 120);
            TxtDesc.TabIndex = 2;
            TxtDesc.Text = "";
            // 
            // TxtTema
            // 
            TxtTema.FormattingEnabled = true;
            TxtTema.Items.AddRange(new object[] { "Aventura", "Infantil", "Português", "Matemática", "Ciencias", "História", "Geografia", "Inglês" });
            TxtTema.Location = new Point(228, 141);
            TxtTema.Name = "TxtTema";
            TxtTema.Size = new Size(151, 28);
            TxtTema.TabIndex = 3;
            // 
            // TxtFaixaEt
            // 
            TxtFaixaEt.FormattingEnabled = true;
            TxtFaixaEt.Items.AddRange(new object[] { "Livre", "+6 anos", "+8 anos", "+12 anos", "+16 anos" });
            TxtFaixaEt.Location = new Point(228, 233);
            TxtFaixaEt.Name = "TxtFaixaEt";
            TxtFaixaEt.Size = new Size(151, 28);
            TxtFaixaEt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "Jogo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 118);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Tema";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 210);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "Faixa Etaria";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCadastrar.Location = new Point(12, 295);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(100, 29);
            BtnCadastrar.TabIndex = 9;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAtualizar.Location = new Point(155, 295);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(100, 29);
            BtnAtualizar.TabIndex = 10;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            BtnDeletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeletar.Location = new Point(279, 295);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(100, 29);
            BtnDeletar.TabIndex = 11;
            BtnDeletar.Text = "Deletar";
            BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 9);
            label5.Name = "label5";
            label5.Size = new Size(209, 25);
            label5.TabIndex = 12;
            label5.Text = "Gerenciamento de Jogos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1177, 366);
            Controls.Add(label5);
            Controls.Add(BtnDeletar);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnCadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtFaixaEt);
            Controls.Add(TxtTema);
            Controls.Add(TxtDesc);
            Controls.Add(TxtJogo);
            Controls.Add(JogosGridView);
            Name = "Form1";
            Text = "Jogos- Messier Data Base";
            ((System.ComponentModel.ISupportInitialize)JogosGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView JogosGridView;
        private TextBox TxtJogo;
        private RichTextBox TxtDesc;
        private ComboBox TxtTema;
        private ComboBox TxtFaixaEt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnCadastrar;
        private Button BtnAtualizar;
        private Button BtnDeletar;
        private Label label5;
    }
}
