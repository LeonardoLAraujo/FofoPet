<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_COD = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NOME_PROD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_QUANT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMB_TIPO_PROD = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PRECO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_TAMANHO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_DETALHE = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.BTN_EXCLUIR = New System.Windows.Forms.Button()
        Me.BTN_GRAVAR = New System.Windows.Forms.Button()
        Me.BTN_ALTERAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÓDIGO"
        '
        'TXT_COD
        '
        Me.TXT_COD.Location = New System.Drawing.Point(19, 56)
        Me.TXT_COD.Mask = "00000"
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.Size = New System.Drawing.Size(62, 20)
        Me.TXT_COD.TabIndex = 1
        Me.TXT_COD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOME DO PRODUTO"
        '
        'TXT_NOME_PROD
        '
        Me.TXT_NOME_PROD.Location = New System.Drawing.Point(18, 117)
        Me.TXT_NOME_PROD.Name = "TXT_NOME_PROD"
        Me.TXT_NOME_PROD.Size = New System.Drawing.Size(404, 20)
        Me.TXT_NOME_PROD.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "QUANTIDADE"
        '
        'TXT_QUANT
        '
        Me.TXT_QUANT.Location = New System.Drawing.Point(429, 117)
        Me.TXT_QUANT.Name = "TXT_QUANT"
        Me.TXT_QUANT.Size = New System.Drawing.Size(184, 20)
        Me.TXT_QUANT.TabIndex = 6
        Me.TXT_QUANT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TIPO DO PRODUTO"
        '
        'CMB_TIPO_PROD
        '
        Me.CMB_TIPO_PROD.FormattingEnabled = True
        Me.CMB_TIPO_PROD.Location = New System.Drawing.Point(18, 174)
        Me.CMB_TIPO_PROD.Name = "CMB_TIPO_PROD"
        Me.CMB_TIPO_PROD.Size = New System.Drawing.Size(403, 21)
        Me.CMB_TIPO_PROD.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PREÇO"
        '
        'TXT_PRECO
        '
        Me.TXT_PRECO.Location = New System.Drawing.Point(429, 175)
        Me.TXT_PRECO.Name = "TXT_PRECO"
        Me.TXT_PRECO.Size = New System.Drawing.Size(184, 20)
        Me.TXT_PRECO.TabIndex = 11
        Me.TXT_PRECO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TAMANHO"
        '
        'TXT_TAMANHO
        '
        Me.TXT_TAMANHO.Location = New System.Drawing.Point(18, 237)
        Me.TXT_TAMANHO.Name = "TXT_TAMANHO"
        Me.TXT_TAMANHO.Size = New System.Drawing.Size(246, 20)
        Me.TXT_TAMANHO.TabIndex = 20
        Me.TXT_TAMANHO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(298, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "DETALHE"
        '
        'TXT_DETALHE
        '
        Me.TXT_DETALHE.Location = New System.Drawing.Point(300, 237)
        Me.TXT_DETALHE.Name = "TXT_DETALHE"
        Me.TXT_DETALHE.Size = New System.Drawing.Size(313, 20)
        Me.TXT_DETALHE.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.FofoPet.My.Resources.Resources.FOFOPET_L
        Me.PictureBox1.Location = New System.Drawing.Point(383, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Consultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = Global.FofoPet.My.Resources.Resources.search_icon
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Consultar.Location = New System.Drawing.Point(321, 308)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(134, 50)
        Me.btn_Consultar.TabIndex = 17
        Me.btn_Consultar.Text = "Consultar"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Consultar.UseVisualStyleBackColor = False
        '
        'BTN_EXCLUIR
        '
        Me.BTN_EXCLUIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_EXCLUIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_EXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXCLUIR.Image = Global.FofoPet.My.Resources.Resources.excluir
        Me.BTN_EXCLUIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_EXCLUIR.Location = New System.Drawing.Point(480, 309)
        Me.BTN_EXCLUIR.Name = "BTN_EXCLUIR"
        Me.BTN_EXCLUIR.Size = New System.Drawing.Size(133, 50)
        Me.BTN_EXCLUIR.TabIndex = 16
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
        Me.BTN_GRAVAR.Image = Global.FofoPet.My.Resources.Resources.gravarProduto
        Me.BTN_GRAVAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_GRAVAR.Location = New System.Drawing.Point(22, 308)
        Me.BTN_GRAVAR.Name = "BTN_GRAVAR"
        Me.BTN_GRAVAR.Size = New System.Drawing.Size(123, 50)
        Me.BTN_GRAVAR.TabIndex = 15
        Me.BTN_GRAVAR.Text = "Salvar"
        Me.BTN_GRAVAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_GRAVAR.UseVisualStyleBackColor = False
        '
        'BTN_ALTERAR
        '
        Me.BTN_ALTERAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ALTERAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ALTERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ALTERAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALTERAR.Image = Global.FofoPet.My.Resources.Resources.gravarProduto
        Me.BTN_ALTERAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_ALTERAR.Location = New System.Drawing.Point(164, 309)
        Me.BTN_ALTERAR.Name = "BTN_ALTERAR"
        Me.BTN_ALTERAR.Size = New System.Drawing.Size(134, 50)
        Me.BTN_ALTERAR.TabIndex = 24
        Me.BTN_ALTERAR.Text = "Alterar"
        Me.BTN_ALTERAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_ALTERAR.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(636, 371)
        Me.Controls.Add(Me.BTN_ALTERAR)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXT_DETALHE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_TAMANHO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Consultar)
        Me.Controls.Add(Me.BTN_EXCLUIR)
        Me.Controls.Add(Me.BTN_GRAVAR)
        Me.Controls.Add(Me.TXT_PRECO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CMB_TIPO_PROD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_QUANT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_NOME_PROD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_COD)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Produto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_COD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_NOME_PROD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_QUANT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMB_TIPO_PROD As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_PRECO As System.Windows.Forms.TextBox
    Friend WithEvents BTN_GRAVAR As System.Windows.Forms.Button
    Friend WithEvents BTN_EXCLUIR As System.Windows.Forms.Button
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_TAMANHO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_DETALHE As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ALTERAR As System.Windows.Forms.Button
End Class
