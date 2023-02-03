<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CPF_CADASTRAR = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_NOME_CADASTRAR = New System.Windows.Forms.TextBox()
        Me.TXT_SENHA_CADASTRAR = New System.Windows.Forms.TextBox()
        Me.TXT_RSENHA_CADASTRAR = New System.Windows.Forms.TextBox()
        Me.BTN_CADASTRAR_CONTA = New System.Windows.Forms.Button()
        Me.BNT_CONSULTAR_CONTAS = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CBM_CARGO = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SENHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "REPITA A SENHA"
        '
        'TXT_CPF_CADASTRAR
        '
        Me.TXT_CPF_CADASTRAR.Location = New System.Drawing.Point(15, 46)
        Me.TXT_CPF_CADASTRAR.Mask = "999,999,999-99"
        Me.TXT_CPF_CADASTRAR.Name = "TXT_CPF_CADASTRAR"
        Me.TXT_CPF_CADASTRAR.Size = New System.Drawing.Size(105, 20)
        Me.TXT_CPF_CADASTRAR.TabIndex = 18
        Me.TXT_CPF_CADASTRAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOME_CADASTRAR
        '
        Me.TXT_NOME_CADASTRAR.Location = New System.Drawing.Point(15, 101)
        Me.TXT_NOME_CADASTRAR.Name = "TXT_NOME_CADASTRAR"
        Me.TXT_NOME_CADASTRAR.Size = New System.Drawing.Size(440, 20)
        Me.TXT_NOME_CADASTRAR.TabIndex = 19
        '
        'TXT_SENHA_CADASTRAR
        '
        Me.TXT_SENHA_CADASTRAR.Location = New System.Drawing.Point(15, 158)
        Me.TXT_SENHA_CADASTRAR.Name = "TXT_SENHA_CADASTRAR"
        Me.TXT_SENHA_CADASTRAR.Size = New System.Drawing.Size(218, 20)
        Me.TXT_SENHA_CADASTRAR.TabIndex = 20
        Me.TXT_SENHA_CADASTRAR.UseSystemPasswordChar = True
        '
        'TXT_RSENHA_CADASTRAR
        '
        Me.TXT_RSENHA_CADASTRAR.Location = New System.Drawing.Point(252, 158)
        Me.TXT_RSENHA_CADASTRAR.Name = "TXT_RSENHA_CADASTRAR"
        Me.TXT_RSENHA_CADASTRAR.Size = New System.Drawing.Size(203, 20)
        Me.TXT_RSENHA_CADASTRAR.TabIndex = 21
        Me.TXT_RSENHA_CADASTRAR.UseSystemPasswordChar = True
        '
        'BTN_CADASTRAR_CONTA
        '
        Me.BTN_CADASTRAR_CONTA.BackColor = System.Drawing.Color.Lime
        Me.BTN_CADASTRAR_CONTA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_CADASTRAR_CONTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CADASTRAR_CONTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CADASTRAR_CONTA.ForeColor = System.Drawing.Color.Black
        Me.BTN_CADASTRAR_CONTA.Image = Global.FofoPet.My.Resources.Resources.gravar
        Me.BTN_CADASTRAR_CONTA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_CADASTRAR_CONTA.Location = New System.Drawing.Point(15, 273)
        Me.BTN_CADASTRAR_CONTA.Name = "BTN_CADASTRAR_CONTA"
        Me.BTN_CADASTRAR_CONTA.Size = New System.Drawing.Size(130, 50)
        Me.BTN_CADASTRAR_CONTA.TabIndex = 26
        Me.BTN_CADASTRAR_CONTA.Text = "Cadastrar Conta"
        Me.BTN_CADASTRAR_CONTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_CADASTRAR_CONTA.UseVisualStyleBackColor = False
        '
        'BNT_CONSULTAR_CONTAS
        '
        Me.BNT_CONSULTAR_CONTAS.BackColor = System.Drawing.Color.Cyan
        Me.BNT_CONSULTAR_CONTAS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BNT_CONSULTAR_CONTAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNT_CONSULTAR_CONTAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNT_CONSULTAR_CONTAS.ForeColor = System.Drawing.Color.Black
        Me.BNT_CONSULTAR_CONTAS.Image = Global.FofoPet.My.Resources.Resources.search_icon
        Me.BNT_CONSULTAR_CONTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BNT_CONSULTAR_CONTAS.Location = New System.Drawing.Point(164, 273)
        Me.BNT_CONSULTAR_CONTAS.Name = "BNT_CONSULTAR_CONTAS"
        Me.BNT_CONSULTAR_CONTAS.Size = New System.Drawing.Size(144, 50)
        Me.BNT_CONSULTAR_CONTAS.TabIndex = 25
        Me.BNT_CONSULTAR_CONTAS.Text = "Consultar Contas"
        Me.BNT_CONSULTAR_CONTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BNT_CONSULTAR_CONTAS.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.FofoPet.My.Resources.Resources.FOFOPET_L
        Me.PictureBox1.Location = New System.Drawing.Point(243, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'CBM_CARGO
        '
        Me.CBM_CARGO.FormattingEnabled = True
        Me.CBM_CARGO.Location = New System.Drawing.Point(15, 217)
        Me.CBM_CARGO.Name = "CBM_CARGO"
        Me.CBM_CARGO.Size = New System.Drawing.Size(218, 21)
        Me.CBM_CARGO.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "CARGO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.FofoPet.My.Resources.Resources.excluir
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(327, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 50)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Excluir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(467, 334)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBM_CARGO)
        Me.Controls.Add(Me.BTN_CADASTRAR_CONTA)
        Me.Controls.Add(Me.BNT_CONSULTAR_CONTAS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXT_RSENHA_CADASTRAR)
        Me.Controls.Add(Me.TXT_SENHA_CADASTRAR)
        Me.Controls.Add(Me.TXT_NOME_CADASTRAR)
        Me.Controls.Add(Me.TXT_CPF_CADASTRAR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Conta de Funcionário"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_CPF_CADASTRAR As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXT_NOME_CADASTRAR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_SENHA_CADASTRAR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_RSENHA_CADASTRAR As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BNT_CONSULTAR_CONTAS As System.Windows.Forms.Button
    Friend WithEvents BTN_CADASTRAR_CONTA As System.Windows.Forms.Button
    Friend WithEvents CBM_CARGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
