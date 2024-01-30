<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCafe = New System.Windows.Forms.Button()
        Me.btnPao = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnRissol = New System.Windows.Forms.Button()
        Me.btnCroquete = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnChocolate = New System.Windows.Forms.Button()
        Me.btnBolo = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnSoda = New System.Windows.Forms.Button()
        Me.btnVinho = New System.Windows.Forms.Button()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPagamento = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(22, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(649, 476)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCafe)
        Me.TabPage1.Controls.Add(Me.btnPao)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(641, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cafe"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCafe
        '
        Me.btnCafe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCafe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCafe.Image = Global.Cafe_Quente.My.Resources.Resources.Cafe2
        Me.btnCafe.Location = New System.Drawing.Point(33, 24)
        Me.btnCafe.Name = "btnCafe"
        Me.btnCafe.Size = New System.Drawing.Size(127, 98)
        Me.btnCafe.TabIndex = 3
        Me.btnCafe.Text = "Cafe"
        Me.btnCafe.UseVisualStyleBackColor = True
        '
        'btnPao
        '
        Me.btnPao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPao.Image = Global.Cafe_Quente.My.Resources.Resources.Pao
        Me.btnPao.Location = New System.Drawing.Point(33, 147)
        Me.btnPao.Name = "btnPao"
        Me.btnPao.Size = New System.Drawing.Size(127, 92)
        Me.btnPao.TabIndex = 2
        Me.btnPao.Text = "Pao"
        Me.btnPao.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnRissol)
        Me.TabPage2.Controls.Add(Me.btnCroquete)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(641, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salgados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnRissol
        '
        Me.btnRissol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRissol.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRissol.Image = Global.Cafe_Quente.My.Resources.Resources.Rissol
        Me.btnRissol.Location = New System.Drawing.Point(24, 156)
        Me.btnRissol.Name = "btnRissol"
        Me.btnRissol.Size = New System.Drawing.Size(127, 107)
        Me.btnRissol.TabIndex = 1
        Me.btnRissol.Text = "Rissol"
        Me.btnRissol.UseVisualStyleBackColor = True
        '
        'btnCroquete
        '
        Me.btnCroquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCroquete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCroquete.Image = Global.Cafe_Quente.My.Resources.Resources.Croquete
        Me.btnCroquete.Location = New System.Drawing.Point(24, 25)
        Me.btnCroquete.Name = "btnCroquete"
        Me.btnCroquete.Size = New System.Drawing.Size(127, 107)
        Me.btnCroquete.TabIndex = 0
        Me.btnCroquete.Text = "Croquete"
        Me.btnCroquete.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnChocolate)
        Me.TabPage3.Controls.Add(Me.btnBolo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(641, 447)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Doces"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnChocolate
        '
        Me.btnChocolate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChocolate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnChocolate.Image = Global.Cafe_Quente.My.Resources.Resources.Chocolate2
        Me.btnChocolate.Location = New System.Drawing.Point(37, 161)
        Me.btnChocolate.Name = "btnChocolate"
        Me.btnChocolate.Size = New System.Drawing.Size(160, 91)
        Me.btnChocolate.TabIndex = 2
        Me.btnChocolate.Text = "Chocolate"
        Me.btnChocolate.UseVisualStyleBackColor = True
        '
        'btnBolo
        '
        Me.btnBolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBolo.Image = Global.Cafe_Quente.My.Resources.Resources.Bolo3
        Me.btnBolo.Location = New System.Drawing.Point(37, 39)
        Me.btnBolo.Name = "btnBolo"
        Me.btnBolo.Size = New System.Drawing.Size(160, 90)
        Me.btnBolo.TabIndex = 1
        Me.btnBolo.Text = "Bolo"
        Me.btnBolo.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnSoda)
        Me.TabPage4.Controls.Add(Me.btnVinho)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(641, 447)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Bebidas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnSoda
        '
        Me.btnSoda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSoda.Image = Global.Cafe_Quente.My.Resources.Resources.Soda
        Me.btnSoda.Location = New System.Drawing.Point(43, 162)
        Me.btnSoda.Name = "btnSoda"
        Me.btnSoda.Size = New System.Drawing.Size(126, 93)
        Me.btnSoda.TabIndex = 1
        Me.btnSoda.Text = "Soda"
        Me.btnSoda.UseVisualStyleBackColor = True
        '
        'btnVinho
        '
        Me.btnVinho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVinho.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVinho.Image = Global.Cafe_Quente.My.Resources.Resources.Vinho
        Me.btnVinho.Location = New System.Drawing.Point(43, 38)
        Me.btnVinho.Name = "btnVinho"
        Me.btnVinho.Size = New System.Drawing.Size(126, 91)
        Me.btnVinho.TabIndex = 0
        Me.btnVinho.Text = "Vinho"
        Me.btnVinho.UseVisualStyleBackColor = True
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(677, 53)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersWidth = 51
        Me.dgvProdutos.RowTemplate.Height = 24
        Me.dgvProdutos.Size = New System.Drawing.Size(273, 447)
        Me.dgvProdutos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(773, 512)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(820, 506)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 22)
        Me.TextBox1.TabIndex = 3
        '
        'btnPagamento
        '
        Me.btnPagamento.Location = New System.Drawing.Point(820, 534)
        Me.btnPagamento.Name = "btnPagamento"
        Me.btnPagamento.Size = New System.Drawing.Size(130, 37)
        Me.btnPagamento.TabIndex = 4
        Me.btnPagamento.Text = "Pagamento"
        Me.btnPagamento.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 588)
        Me.Controls.Add(Me.btnPagamento)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Pao Quente - Cafe"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnBolo As Button
    Friend WithEvents btnCafe As Button
    Friend WithEvents btnPao As Button
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnPagamento As Button
    Friend WithEvents btnCroquete As Button
    Friend WithEvents btnRissol As Button
    Friend WithEvents btnChocolate As Button
    Friend WithEvents btnSoda As Button
    Friend WithEvents btnVinho As Button
End Class
