Public Class Form1
    Private Sub btnCafe_MouseHover(sender As Object, e As EventArgs) Handles btnCafe.MouseHover, btnPao.MouseHover, btnBolo.MouseHover, btnCroquete.MouseHover, btnRissol.MouseHover, btnChocolate.MouseHover, btnVinho.MouseHover, btnSoda.MouseHover
        'btnCafe.Image = My.Resources.cor

        Dim btn As Button

        btn = CType(sender, Button)
        btn.Image = My.Resources.cor

    End Sub

    Private Sub btnCafe_MouseLeave(sender As Object, e As EventArgs) Handles btnCafe.MouseLeave
        btnCafe.Image = My.Resources.Cafe2
    End Sub

    Private Sub btnPao_MouseLeave(sender As Object, e As EventArgs) Handles btnPao.MouseLeave
        btnPao.Image = My.Resources.Pao
    End Sub

    Private Sub btnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click
        InserirLinhas(btnCafe.Text, 0.65)
    End Sub

    Private Sub InserirLinhas(produto As String, preco As String)
        dgvProdutos.Rows.Add(produto, preco)
        TextBox1.Text = Format(CDbl("0" + TextBox1.Text) + preco, "0.00 €")

    End Sub

    Private Sub InicializarGrid()
        With dgvProdutos
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .MultiSelect = False
            .ReadOnly = True
            .Columns.Add("Produto", "Produto")
            .Columns.Add("Preco", "Preço €")
            .Font = New Font("Tahoma", 8.25)
            .Columns(0).Width = 150
            .Columns(1).Width = 50
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox1.TextAlign = HorizontalAlignment.Right
        InicializarGrid()
    End Sub

    Private Sub btnPao_Click(sender As Object, e As EventArgs) Handles btnPao.Click
        InserirLinhas(btnPao.Text, 0.2)

    End Sub

    Private Sub btnVinho_Click(sender As Object, e As EventArgs) Handles btnVinho.Click
        InserirLinhas(btnVinho.Text, 1.5)
    End Sub

    Private Sub btnCroquete_Click(sender As Object, e As EventArgs) Handles btnCroquete.Click
        InserirLinhas(btnCroquete.Text, 1.0)
    End Sub

    Private Sub btnRissol_Click(sender As Object, e As EventArgs) Handles btnRissol.Click
        InserirLinhas(btnRissol.Text, 1.0)
    End Sub

    Private Sub btnBolo_Click(sender As Object, e As EventArgs) Handles btnBolo.Click
        InserirLinhas(btnBolo.Text, 2.0)
    End Sub

    Private Sub btnChocolate_Click(sender As Object, e As EventArgs) Handles btnChocolate.Click
        InserirLinhas(btnChocolate.Text, 1.5)
    End Sub

    Private Sub btnSoda_Click(sender As Object, e As EventArgs) Handles btnSoda.Click
        InserirLinhas(btnSoda.Text, 1.5)
    End Sub

    Private Sub btnCroquete_MouseLeave(sender As Object, e As EventArgs) Handles btnCroquete.MouseLeave
        btnCroquete.Image = My.Resources.Croquete
    End Sub

    Private Sub btnRissol_MouseLeave(sender As Object, e As EventArgs) Handles btnRissol.MouseLeave
        btnRissol.Image = My.Resources.Rissol
    End Sub

    Private Sub btnBolo_MouseLeave(sender As Object, e As EventArgs) Handles btnBolo.MouseLeave
        btnBolo.Image = My.Resources.Bolo3
    End Sub

    Private Sub btnChocolate_MouseLeave(sender As Object, e As EventArgs) Handles btnChocolate.MouseLeave
        btnChocolate.Image = My.Resources.Chocolate2
    End Sub

    Private Sub btnVinho_MouseLeave(sender As Object, e As EventArgs) Handles btnVinho.MouseLeave
        btnVinho.Image = My.Resources.Vinho
    End Sub

    Private Sub btnSoda_MouseLeave(sender As Object, e As EventArgs) Handles btnSoda.MouseLeave
        btnSoda.Image = My.Resources.Soda
    End Sub

    Private Sub btnPagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        FormPagamento.ShowDialog()
    End Sub
End Class
