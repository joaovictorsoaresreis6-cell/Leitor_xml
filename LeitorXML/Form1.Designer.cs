namespace LeitorXML
{
    partial class Form1
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
            btnSelecionarXML = new Button();
            btnSalvarBanco = new Button();
            openFileDialogXML = new OpenFileDialog();
            btnLerXML = new Button();
            btnValidarXML = new Button();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblSerie = new Label();
            txtSerie = new TextBox();
            lblData = new Label();
            txtData = new TextBox();
            lblChave = new Label();
            txtChave = new TextBox();
            lblEmitente = new Label();
            txtEmitente = new TextBox();
            lblCNPJ = new Label();
            txtCNPJ = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            GroupBox = new GroupBox();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionarXML
            // 
            btnSelecionarXML.Location = new Point(40, 50);
            btnSelecionarXML.Name = "btnSelecionarXML";
            btnSelecionarXML.Size = new Size(170, 23);
            btnSelecionarXML.TabIndex = 0;
            btnSelecionarXML.Text = "Selecionar XML";
            btnSelecionarXML.UseVisualStyleBackColor = true;
            btnSelecionarXML.Click += btnSelecionarXML_Click;
            // 
            // btnSalvarBanco
            // 
            btnSalvarBanco.Location = new Point(40, 179);
            btnSalvarBanco.Name = "btnSalvarBanco";
            btnSalvarBanco.Size = new Size(170, 23);
            btnSalvarBanco.TabIndex = 1;
            btnSalvarBanco.Text = "Salvar no Banco";
            btnSalvarBanco.UseVisualStyleBackColor = true;
            btnSalvarBanco.Click += btnSalvarBanco_Click;
            // 
            // openFileDialogXML
            // 
            openFileDialogXML.FileName = "openFileDialog1";
            openFileDialogXML.FileOk += openFileDialogXML_FileOk;
            // 
            // btnLerXML
            // 
            btnLerXML.Location = new Point(40, 95);
            btnLerXML.Name = "btnLerXML";
            btnLerXML.Size = new Size(170, 23);
            btnLerXML.TabIndex = 2;
            btnLerXML.Text = "Ler XML";
            btnLerXML.UseVisualStyleBackColor = true;
            btnLerXML.Click += btnLerXML_Click;
            // 
            // btnValidarXML
            // 
            btnValidarXML.Location = new Point(40, 136);
            btnValidarXML.Name = "btnValidarXML";
            btnValidarXML.Size = new Size(170, 23);
            btnValidarXML.TabIndex = 3;
            btnValidarXML.Text = "Validar XML";
            btnValidarXML.UseVisualStyleBackColor = true;
            btnValidarXML.Click += btnValidarXML_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(21, 29);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(69, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número NF";
            lblNumero.Click += lblNumero_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(144, 29);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(350, 23);
            txtNumero.TabIndex = 5;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(37, 83);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(32, 15);
            lblSerie.TabIndex = 6;
            lblSerie.Text = "Série";
            lblSerie.Click += lblSerie_Click;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(144, 75);
            txtSerie.Name = "txtSerie";
            txtSerie.ReadOnly = true;
            txtSerie.Size = new Size(350, 23);
            txtSerie.TabIndex = 7;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(21, 124);
            lblData.Name = "lblData";
            lblData.Size = new Size(77, 15);
            lblData.TabIndex = 8;
            lblData.Text = "Data emissão";
            // 
            // txtData
            // 
            txtData.Location = new Point(144, 124);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(350, 23);
            txtData.TabIndex = 9;
            // 
            // lblChave
            // 
            lblChave.AutoSize = true;
            lblChave.Location = new Point(20, 171);
            lblChave.Name = "lblChave";
            lblChave.Size = new Size(94, 15);
            lblChave.TabIndex = 10;
            lblChave.Text = "Chave de acesso";
            // 
            // txtChave
            // 
            txtChave.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChave.Location = new Point(144, 173);
            txtChave.Name = "txtChave";
            txtChave.ReadOnly = true;
            txtChave.Size = new Size(350, 22);
            txtChave.TabIndex = 11;
            // 
            // lblEmitente
            // 
            lblEmitente.AutoSize = true;
            lblEmitente.Location = new Point(20, 224);
            lblEmitente.Name = "lblEmitente";
            lblEmitente.Size = new Size(54, 15);
            lblEmitente.TabIndex = 12;
            lblEmitente.Text = "Emitente";
            // 
            // txtEmitente
            // 
            txtEmitente.Location = new Point(144, 224);
            txtEmitente.Name = "txtEmitente";
            txtEmitente.ReadOnly = true;
            txtEmitente.Size = new Size(350, 23);
            txtEmitente.TabIndex = 13;
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(27, 288);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(84, 15);
            lblCNPJ.TabIndex = 14;
            lblCNPJ.Text = "CNPJ Emitente";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(144, 288);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(350, 23);
            txtCNPJ.TabIndex = 15;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(24, 353);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 15);
            lblValor.TabIndex = 16;
            lblValor.Text = "Valor Total";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(144, 353);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(350, 23);
            txtValor.TabIndex = 17;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(lblNumero);
            GroupBox.Controls.Add(txtValor);
            GroupBox.Controls.Add(txtNumero);
            GroupBox.Controls.Add(lblValor);
            GroupBox.Controls.Add(lblSerie);
            GroupBox.Controls.Add(txtCNPJ);
            GroupBox.Controls.Add(txtSerie);
            GroupBox.Controls.Add(lblCNPJ);
            GroupBox.Controls.Add(lblData);
            GroupBox.Controls.Add(txtEmitente);
            GroupBox.Controls.Add(txtData);
            GroupBox.Controls.Add(lblEmitente);
            GroupBox.Controls.Add(lblChave);
            GroupBox.Controls.Add(txtChave);
            GroupBox.Location = new Point(556, 12);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(505, 418);
            GroupBox.TabIndex = 18;
            GroupBox.TabStop = false;
            GroupBox.Text = "Dados Nota Fiscal";
            GroupBox.Enter += GroupBox_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 475);
            Controls.Add(GroupBox);
            Controls.Add(btnValidarXML);
            Controls.Add(btnLerXML);
            Controls.Add(btnSalvarBanco);
            Controls.Add(btnSelecionarXML);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelecionarXML;
        private Button btnSalvarBanco;
        private OpenFileDialog openFileDialogXML;
        private Button btnLerXML;
        private Button btnValidarXML;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblSerie;
        private TextBox txtSerie;
        private Label lblData;
        private TextBox txtData;
        private Label lblChave;
        private TextBox txtChave;
        private Label lblEmitente;
        private TextBox txtEmitente;
        private Label lblCNPJ;
        private TextBox txtCNPJ;
        private Label lblValor;
        private TextBox txtValor;
        private GroupBox GroupBox;
    }
}
