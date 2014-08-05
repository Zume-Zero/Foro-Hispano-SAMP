Imports System
Imports System.Windows.Forms
Imports System.Security.Permissions

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
Public Class Form1
    Dim DefaultText As String = "Búsqueda en wiki.sa-mp.."

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripSeparator6.Text = DefaultText
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Stop()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoHome()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WebBrowser1.Navigate(Me.ToolStripSeparator6.Text)
        Me.Text = Me.WebBrowser1.DocumentTitle
    End Sub

    Private Sub ToolStripSeparator6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator6.Click
        If ToolStripSeparator6.Text = DefaultText Then
            ToolStripSeparator6.Text = ""
        Else
            ToolStripSeparator6.SelectAll()
        End If
    End Sub

    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If (WebBrowser1.CanGoBack) Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If (WebBrowser1.CanGoForward) Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If Not WebBrowser1.Url.Equals("about:blank") Then
            WebBrowser1.Refresh()
        End If
    End Sub

    Private Sub ToolStripLabel2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        If String.IsNullOrEmpty(ToolStripSeparator6.Text) Or ToolStripSeparator6.Text.Equals("about:blank") Or ToolStripSeparator6.Text.Equals(DefaultText) Then Return

        Dim url As String = "http://wiki.sa-mp.com/wiki/Special:Search?search=" & ToolStripSeparator6.Text & "&go=Go"
        Me.WebBrowser1.Navigate(url)
        ToolStripSeparator6.Text = url

        Try
            Me.WebBrowser1.Navigate(url)
        Catch ex As System.UriFormatException
            Return
        End Try
    End Sub

    Private Sub ToolStripSeparator6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripSeparator6.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If String.IsNullOrEmpty(ToolStripSeparator6.Text) Or ToolStripSeparator6.Text.Equals("about:blank") Or ToolStripSeparator6.Text.Equals(DefaultText) Then Return
            Dim url As String = "http://wiki.sa-mp.com/wiki/Special:Search?search=" & ToolStripSeparator6.Text & "&go=Go"
            Me.WebBrowser1.Navigate(url)
            ToolStripSeparator6.Text = url
            Try
                Me.WebBrowser1.Navigate(url)
            Catch ex As System.UriFormatException
                Return
            End Try
        End If

    End Sub


    Private Sub Cliente03zRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente03zRToolStripMenuItem.Click
        Me.WebBrowser1.Navigate("http://files.sa-mp.com/samp03z_svr_R1_win32.zip")
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub DescargasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargasToolStripMenuItem.Click

    End Sub

    Private Sub SAMP03zLinuxServerx86ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMP03zLinuxServerx86ToolStripMenuItem.Click
        Me.WebBrowser1.Navigate("http://files.sa-mp.com/samp03zsvr_R1.tar.gz")
    End Sub

    Private Sub IDDeVehículosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDDeVehículosToolStripMenuItem.Click

        Form2.Hide()
        Form2.Hide()
        Form3.Show()
    End Sub

    Private Sub SAMPSkinsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMPSkinsToolStripMenuItem.Click
        Form3.Hide()
        Form2.Hide()
        Form2.Show()
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        Me.WebBrowser1.Navigate("http://forum.sa-mp.com/forumdisplay.php?f=29")
    End Sub

    Private Sub ToolStripButton5_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.ButtonClick

    End Sub

    Private Sub InicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        Me.WebBrowser1.Navigate("http://forum.sa-mp.com/forumdisplay.php?f=29")
    End Sub

    Private Sub IndexDeSAMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexDeSAMPToolStripMenuItem.Click
        Me.WebBrowser1.Navigate("http://SA-MP.com")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator6.TextChanged

    End Sub


    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub ToolStripContainer1_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class
