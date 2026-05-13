namespace PrototipoMessier
{
    partial class MessierDB
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
            tabControl1 = new TabControl();
            TabInicio = new TabPage();
            TabJogos = new TabPage();
            TabPacotes = new TabPage();
            TabAjuda = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabInicio);
            tabControl1.Controls.Add(TabJogos);
            tabControl1.Controls.Add(TabPacotes);
            tabControl1.Controls.Add(TabAjuda);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1060, 670);
            tabControl1.TabIndex = 0;
            // 
            // TabInicio
            // 
            TabInicio.Location = new Point(4, 29);
            TabInicio.Name = "TabInicio";
            TabInicio.Padding = new Padding(3);
            TabInicio.Size = new Size(1052, 637);
            TabInicio.TabIndex = 0;
            TabInicio.Text = "Inicio";
            TabInicio.UseVisualStyleBackColor = true;
            // 
            // TabJogos
            // 
            TabJogos.Location = new Point(4, 29);
            TabJogos.Name = "TabJogos";
            TabJogos.Padding = new Padding(3);
            TabJogos.Size = new Size(1106, 636);
            TabJogos.TabIndex = 1;
            TabJogos.Text = "Jogos";
            TabJogos.UseVisualStyleBackColor = true;
            // 
            // TabPacotes
            // 
            TabPacotes.Location = new Point(4, 29);
            TabPacotes.Name = "TabPacotes";
            TabPacotes.Padding = new Padding(3);
            TabPacotes.Size = new Size(1106, 636);
            TabPacotes.TabIndex = 2;
            TabPacotes.Text = "Pacotes";
            TabPacotes.UseVisualStyleBackColor = true;
            // 
            // TabAjuda
            // 
            TabAjuda.Location = new Point(4, 29);
            TabAjuda.Name = "TabAjuda";
            TabAjuda.Padding = new Padding(3);
            TabAjuda.Size = new Size(1106, 636);
            TabAjuda.TabIndex = 3;
            TabAjuda.Text = "Ajuda";
            TabAjuda.UseVisualStyleBackColor = true;
            // 
            // MessierDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tabControl1);
            Name = "MessierDB";
            Text = "Messier Data Base";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabInicio;
        private TabPage TabJogos;
        private TabPage TabPacotes;
        private TabPage TabAjuda;
    }
}
