<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.TXT_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NOME = New System.Windows.Forms.TextBox()
        Me.TXT_EMAIL = New System.Windows.Forms.Label()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.BTN_EXCLUIR = New System.Windows.Forms.Button()
        Me.BTN_GRAVAR = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_MAX = New System.Windows.Forms.Button()
        Me.BTN_MIN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_ENDERECO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_COMPLE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_BAIRRO = New System.Windows.Forms.TextBox()
        Me.TXT_CIDADE = New System.Windows.Forms.TextBox()
        Me.TXT_UF = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_FONE = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_CELU = New System.Windows.Forms.MaskedTextBox()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.TXT_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.BTN_ALTERAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_CPF
        '
        Me.TXT_CPF.Location = New System.Drawing.Point(9, 96)
        Me.TXT_CPF.Mask = "999.999.999-99"
        Me.TXT_CPF.Name = "TXT_CPF"
        Me.TXT_CPF.Size = New System.Drawing.Size(113, 20)
        Me.TXT_CPF.TabIndex = 1
        Me.TXT_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CPF DO CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOME DO CLIENTE"
        '
        'TXT_NOME
        '
        Me.TXT_NOME.Location = New System.Drawing.Point(9, 159)
        Me.TXT_NOME.Name = "TXT_NOME"
        Me.TXT_NOME.Size = New System.Drawing.Size(343, 20)
        Me.TXT_NOME.TabIndex = 4
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.AutoSize = True
        Me.TXT_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EMAIL.Location = New System.Drawing.Point(249, 311)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(48, 13)
        Me.TXT_EMAIL.TabIndex = 5
        Me.TXT_EMAIL.Text = "E-MAIL"
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(249, 327)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(271, 20)
        Me.TXTEMAIL.TabIndex = 6
        '
        'BTN_EXCLUIR
        '
        Me.BTN_EXCLUIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BTN_EXCLUIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_EXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXCLUIR.Image = CType(resources.GetObject("BTN_EXCLUIR.Image"), System.Drawing.Image)
        Me.BTN_EXCLUIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_EXCLUIR.Location = New System.Drawing.Point(414, 368)
        Me.BTN_EXCLUIR.Name = "BTN_EXCLUIR"
        Me.BTN_EXCLUIR.Size = New System.Drawing.Size(106, 47)
        Me.BTN_EXCLUIR.TabIndex = 8
        Me.BTN_EXCLUIR.Text = "Excluir"
        Me.BTN_EXCLUIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_EXCLUIR.UseVisualStyleBackColor = False
        '
        'BTN_GRAVAR
        '
        Me.BTN_GRAVAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_GRAVAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GRAVAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GRAVAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GRAVAR.ForeColor = System.Drawing.Color.Black
        Me.BTN_GRAVAR.Image = CType(resources.GetObject("BTN_GRAVAR.Image"), System.Drawing.Image)
        Me.BTN_GRAVAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_GRAVAR.Location = New System.Drawing.Point(12, 368)
        Me.BTN_GRAVAR.Name = "BTN_GRAVAR"
        Me.BTN_GRAVAR.Size = New System.Drawing.Size(110, 47)
        Me.BTN_GRAVAR.TabIndex = 7
        Me.BTN_GRAVAR.Text = "Salvar"
        Me.BTN_GRAVAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_GRAVAR.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(308, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 255)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.BTN_MAX)
        Me.Panel5.Controls.Add(Me.BTN_MIN)
        Me.Panel5.Location = New System.Drawing.Point(0, -2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(612, 36)
        Me.Panel5.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(494, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_MAX
        '
        Me.BTN_MAX.BackgroundImage = CType(resources.GetObject("BTN_MAX.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MAX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_MAX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_MAX.Location = New System.Drawing.Point(456, 3)
        Me.BTN_MAX.Name = "BTN_MAX"
        Me.BTN_MAX.Size = New System.Drawing.Size(32, 29)
        Me.BTN_MAX.TabIndex = 4
        Me.BTN_MAX.UseVisualStyleBackColor = True
        '
        'BTN_MIN
        '
        Me.BTN_MIN.BackgroundImage = CType(resources.GetObject("BTN_MIN.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_MIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_MIN.Location = New System.Drawing.Point(417, 3)
        Me.BTN_MIN.Name = "BTN_MIN"
        Me.BTN_MIN.Size = New System.Drawing.Size(33, 29)
        Me.BTN_MIN.TabIndex = 3
        Me.BTN_MIN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "CEP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ENDERECO"
        '
        'TXT_ENDERECO
        '
        Me.TXT_ENDERECO.Location = New System.Drawing.Point(95, 219)
        Me.TXT_ENDERECO.Name = "TXT_ENDERECO"
        Me.TXT_ENDERECO.Size = New System.Drawing.Size(246, 20)
        Me.TXT_ENDERECO.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "COMPLEMENTO"
        '
        'TXT_COMPLE
        '
        Me.TXT_COMPLE.Location = New System.Drawing.Point(347, 219)
        Me.TXT_COMPLE.Name = "TXT_COMPLE"
        Me.TXT_COMPLE.Size = New System.Drawing.Size(173, 20)
        Me.TXT_COMPLE.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "BAIRRO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(249, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "CIDADE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(488, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "UF"
        '
        'TXT_BAIRRO
        '
        Me.TXT_BAIRRO.Location = New System.Drawing.Point(9, 276)
        Me.TXT_BAIRRO.Name = "TXT_BAIRRO"
        Me.TXT_BAIRRO.Size = New System.Drawing.Size(234, 20)
        Me.TXT_BAIRRO.TabIndex = 58
        '
        'TXT_CIDADE
        '
        Me.TXT_CIDADE.Location = New System.Drawing.Point(249, 276)
        Me.TXT_CIDADE.Name = "TXT_CIDADE"
        Me.TXT_CIDADE.Size = New System.Drawing.Size(229, 20)
        Me.TXT_CIDADE.TabIndex = 59
        '
        'TXT_UF
        '
        Me.TXT_UF.Location = New System.Drawing.Point(484, 276)
        Me.TXT_UF.Name = "TXT_UF"
        Me.TXT_UF.Size = New System.Drawing.Size(36, 20)
        Me.TXT_UF.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "FONE RESIDENCIAL"
        '
        'TXT_FONE
        '
        Me.TXT_FONE.Location = New System.Drawing.Point(9, 327)
        Me.TXT_FONE.Mask = "(99) 9999-9999"
        Me.TXT_FONE.Name = "TXT_FONE"
        Me.TXT_FONE.Size = New System.Drawing.Size(123, 20)
        Me.TXT_FONE.TabIndex = 62
        Me.TXT_FONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(142, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "CELULAR"
        '
        'TXT_CELU
        '
        Me.TXT_CELU.Location = New System.Drawing.Point(145, 327)
        Me.TXT_CELU.Mask = "(99) 99999-9999"
        Me.TXT_CELU.Name = "TXT_CELU"
        Me.TXT_CELU.Size = New System.Drawing.Size(98, 20)
        Me.TXT_CELU.TabIndex = 64
        Me.TXT_CELU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Consultar
        '
        Me.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Consultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = CType(resources.GetObject("btn_Consultar.Image"), System.Drawing.Image)
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Consultar.Location = New System.Drawing.Point(145, 368)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(110, 47)
        Me.btn_Consultar.TabIndex = 65
        Me.btn_Consultar.Text = "Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Consultar.UseVisualStyleBackColor = False
        '
        'TXT_CEP
        '
        Me.TXT_CEP.Location = New System.Drawing.Point(9, 219)
        Me.TXT_CEP.Mask = "99999-999"
        Me.TXT_CEP.Name = "TXT_CEP"
        Me.TXT_CEP.Size = New System.Drawing.Size(80, 20)
        Me.TXT_CEP.TabIndex = 66
        Me.TXT_CEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_ALTERAR
        '
        Me.BTN_ALTERAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ALTERAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ALTERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ALTERAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALTERAR.Image = CType(resources.GetObject("BTN_ALTERAR.Image"), System.Drawing.Image)
        Me.BTN_ALTERAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_ALTERAR.Location = New System.Drawing.Point(275, 368)
        Me.BTN_ALTERAR.Name = "BTN_ALTERAR"
        Me.BTN_ALTERAR.Size = New System.Drawing.Size(110, 47)
        Me.BTN_ALTERAR.TabIndex = 67
        Me.BTN_ALTERAR.Text = "Alterar"
        Me.BTN_ALTERAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_ALTERAR.UseVisualStyleBackColor = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 445)
        Me.Controls.Add(Me.BTN_ALTERAR)
        Me.Controls.Add(Me.TXT_CEP)
        Me.Controls.Add(Me.btn_Consultar)
        Me.Controls.Add(Me.TXT_CELU)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_FONE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_UF)
        Me.Controls.Add(Me.TXT_CIDADE)
        Me.Controls.Add(Me.TXT_BAIRRO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_COMPLE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_ENDERECO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.BTN_EXCLUIR)
        Me.Controls.Add(Me.BTN_GRAVAR)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.TXT_EMAIL)
        Me.Controls.Add(Me.TXT_NOME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_CPF)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOME As System.Windows.Forms.TextBox
    Friend WithEvents TXT_EMAIL As System.Windows.Forms.Label
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents BTN_GRAVAR As System.Windows.Forms.Button
    Friend WithEvents BTN_EXCLUIR As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTN_MAX As System.Windows.Forms.Button
    Friend WithEvents BTN_MIN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_ENDERECO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_COMPLE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_BAIRRO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CIDADE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_UF As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_FONE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_CELU As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents TXT_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BTN_ALTERAR As System.Windows.Forms.Button

End Class
