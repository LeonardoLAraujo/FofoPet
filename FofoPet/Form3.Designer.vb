<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TXT_SENHA_LOGIN = New System.Windows.Forms.TextBox()
        Me.BTN_ENTRAR = New System.Windows.Forms.Button()
        Me.TXT_CPF_LOGIN = New System.Windows.Forms.MaskedTextBox()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_MAX = New System.Windows.Forms.Button()
        Me.BTN_MIN = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SENHA"
        '
        'TXT_SENHA_LOGIN
        '
        Me.TXT_SENHA_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TXT_SENHA_LOGIN.Location = New System.Drawing.Point(10, 243)
        Me.TXT_SENHA_LOGIN.Name = "TXT_SENHA_LOGIN"
        Me.TXT_SENHA_LOGIN.Size = New System.Drawing.Size(256, 20)
        Me.TXT_SENHA_LOGIN.TabIndex = 18
        Me.TXT_SENHA_LOGIN.UseSystemPasswordChar = True
        '
        'BTN_ENTRAR
        '
        Me.BTN_ENTRAR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTN_ENTRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ENTRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ENTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ENTRAR.ForeColor = System.Drawing.Color.Black
        Me.BTN_ENTRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_ENTRAR.Location = New System.Drawing.Point(11, 298)
        Me.BTN_ENTRAR.Name = "BTN_ENTRAR"
        Me.BTN_ENTRAR.Size = New System.Drawing.Size(122, 32)
        Me.BTN_ENTRAR.TabIndex = 16
        Me.BTN_ENTRAR.Text = "Entrar"
        Me.BTN_ENTRAR.UseVisualStyleBackColor = False
        '
        'TXT_CPF_LOGIN
        '
        Me.TXT_CPF_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TXT_CPF_LOGIN.Location = New System.Drawing.Point(11, 176)
        Me.TXT_CPF_LOGIN.Mask = "999,999,999-99"
        Me.TXT_CPF_LOGIN.Name = "TXT_CPF_LOGIN"
        Me.TXT_CPF_LOGIN.Size = New System.Drawing.Size(122, 20)
        Me.TXT_CPF_LOGIN.TabIndex = 19
        Me.TXT_CPF_LOGIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_fechar
        '
        Me.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_fechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_fechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fechar.ForeColor = System.Drawing.Color.Black
        Me.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_fechar.Location = New System.Drawing.Point(145, 298)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(122, 32)
        Me.btn_fechar.TabIndex = 20
        Me.btn_fechar.Text = "Fechar"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.FofoPet.My.Resources.Resources.FOFOPET_L
        Me.PictureBox1.Location = New System.Drawing.Point(16, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
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
        Me.Panel5.Location = New System.Drawing.Point(-1, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(395, 32)
        Me.Panel5.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.FofoPet.My.Resources.Resources.letra_x
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(241, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_MAX
        '
        Me.BTN_MAX.BackgroundImage = Global.FofoPet.My.Resources.Resources.minimizar__1_
        Me.BTN_MAX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_MAX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_MAX.Location = New System.Drawing.Point(207, 1)
        Me.BTN_MAX.Name = "BTN_MAX"
        Me.BTN_MAX.Size = New System.Drawing.Size(32, 29)
        Me.BTN_MAX.TabIndex = 4
        Me.BTN_MAX.UseVisualStyleBackColor = True
        '
        'BTN_MIN
        '
        Me.BTN_MIN.BackgroundImage = Global.FofoPet.My.Resources.Resources.minimizar
        Me.BTN_MIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_MIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_MIN.Location = New System.Drawing.Point(171, 1)
        Me.BTN_MIN.Name = "BTN_MIN"
        Me.BTN_MIN.Size = New System.Drawing.Size(33, 29)
        Me.BTN_MIN.TabIndex = 3
        Me.BTN_MIN.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(281, 347)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.TXT_CPF_LOGIN)
        Me.Controls.Add(Me.TXT_SENHA_LOGIN)
        Me.Controls.Add(Me.BTN_ENTRAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTN_ENTRAR As System.Windows.Forms.Button
    Friend WithEvents TXT_SENHA_LOGIN As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CPF_LOGIN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_fechar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTN_MAX As System.Windows.Forms.Button
    Friend WithEvents BTN_MIN As System.Windows.Forms.Button
End Class
