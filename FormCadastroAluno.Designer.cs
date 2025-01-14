﻿namespace ProjetoCadastro
{
    partial class FormCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btn__novo = new ReaLTaiizor.Controls.MaterialButton();
            btn_excluir = new ReaLTaiizor.Controls.MaterialButton();
            btn_editar = new ReaLTaiizor.Controls.MaterialButton();
            mlvAlunos = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(4, 80);
            TabControlCadastro.Margin = new Padding(4);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(854, 557);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(cboEstado);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtDataNascimento);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 34);
            tabPageCadastro.Margin = new Padding(4);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(4);
            tabPageCadastro.Size = new Size(846, 519);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(720, 456);
            btnSalvar.Margin = new Padding(5, 8, 5, 8);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(590, 456);
            btnCancelar.Margin = new Padding(5, 8, 5, 8);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.impressao_Digital;
            txtSenha.Location = new Point(30, 371);
            txtSenha.Margin = new Padding(4);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(785, 48);
            txtSenha.TabIndex = 7;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(626, 304);
            cboEstado.Margin = new Padding(4);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(188, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(30, 304);
            txtCidade.Margin = new Padding(4);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(589, 48);
            txtCidade.TabIndex = 5;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AllowPromptAsInput = true;
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AsciiOnly = false;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.BeepOnError = false;
            txtDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HidePromptOnLeave = false;
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(671, 34);
            txtDataNascimento.Margin = new Padding(4);
            txtDataNascimento.Mask = "99/99/9999";
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.PromptChar = '_';
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RejectInputOnFirstFailure = false;
            txtDataNascimento.ResetOnPrompt = true;
            txtDataNascimento.ResetOnSpace = true;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(146, 48);
            txtDataNascimento.SkipLiterals = true;
            txtDataNascimento.TabIndex = 1;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.Text = "  /  /";
            txtDataNascimento.TextAlign = HorizontalAlignment.Center;
            txtDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            txtDataNascimento.ValidatingType = null;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(30, 236);
            txtBairro.Margin = new Padding(4);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(788, 48);
            txtBairro.TabIndex = 4;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(30, 169);
            txtEndereco.Margin = new Padding(4);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(788, 48);
            txtEndereco.TabIndex = 3;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(30, 101);
            txtNome.Margin = new Padding(4);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(788, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(30, 34);
            txtMatricula.Margin = new Padding(4);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(634, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btn__novo);
            tabPageConsulta.Controls.Add(btn_excluir);
            tabPageConsulta.Controls.Add(btn_editar);
            tabPageConsulta.Controls.Add(mlvAlunos);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 34);
            tabPageConsulta.Margin = new Padding(4);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(4);
            tabPageConsulta.Size = new Size(846, 519);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // btn__novo
            // 
            btn__novo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn__novo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn__novo.Depth = 0;
            btn__novo.HighEmphasis = true;
            btn__novo.Icon = null;
            btn__novo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn__novo.Location = new Point(546, 481);
            btn__novo.Margin = new Padding(4, 6, 4, 6);
            btn__novo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn__novo.Name = "btn__novo";
            btn__novo.NoAccentTextColor = Color.Empty;
            btn__novo.Size = new Size(64, 36);
            btn__novo.TabIndex = 3;
            btn__novo.Text = "Novo";
            btn__novo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn__novo.UseAccentColor = false;
            btn__novo.UseVisualStyleBackColor = true;
            btn__novo.Click += btn__novo_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_excluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_excluir.Depth = 0;
            btn_excluir.HighEmphasis = true;
            btn_excluir.Icon = null;
            btn_excluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_excluir.Location = new Point(758, 483);
            btn_excluir.Margin = new Padding(4, 6, 4, 6);
            btn_excluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.NoAccentTextColor = Color.Empty;
            btn_excluir.Size = new Size(80, 36);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_excluir.UseAccentColor = false;
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_editar
            // 
            btn_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_editar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_editar.Depth = 0;
            btn_editar.HighEmphasis = true;
            btn_editar.Icon = null;
            btn_editar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_editar.Location = new Point(665, 481);
            btn_editar.Margin = new Padding(4, 6, 4, 6);
            btn_editar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_editar.Name = "btn_editar";
            btn_editar.NoAccentTextColor = Color.Empty;
            btn_editar.Size = new Size(71, 36);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_editar.UseAccentColor = false;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // mlvAlunos
            // 
            mlvAlunos.AutoSizeTable = false;
            mlvAlunos.BackColor = Color.FromArgb(255, 255, 255);
            mlvAlunos.BorderStyle = BorderStyle.None;
            mlvAlunos.Depth = 0;
            mlvAlunos.Dock = DockStyle.Top;
            mlvAlunos.FullRowSelect = true;
            mlvAlunos.Location = new Point(4, 4);
            mlvAlunos.Margin = new Padding(4);
            mlvAlunos.MinimumSize = new Size(250, 125);
            mlvAlunos.MouseLocation = new Point(-1, -1);
            mlvAlunos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvAlunos.Name = "mlvAlunos";
            mlvAlunos.OwnerDraw = true;
            mlvAlunos.Size = new Size(838, 469);
            mlvAlunos.TabIndex = 0;
            mlvAlunos.UseCompatibleStateImageBehavior = false;
            mlvAlunos.View = View.Details;
            mlvAlunos.MouseDoubleClick += mlvAlunos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            
            
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 641);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Margin = new Padding(4);
            Name = "FormCadastroAluno";
            Padding = new Padding(4, 80, 4, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        public ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialListView mlvAlunos;
        private ReaLTaiizor.Controls.MaterialButton btn_excluir;
        private ReaLTaiizor.Controls.MaterialButton btn_editar;
        private ReaLTaiizor.Controls.MaterialButton btn__novo;
    }
}