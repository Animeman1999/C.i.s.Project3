
Imports System.Drawing

Partial Class Default2
    Inherits System.Web.UI.Page


    Private Const QUESTION_ONE As String = "Are you sure your name is "
    Private Const QUESTION_TWO As String = "You look like a Fred to me, are you sure your name is "

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = TextBox1.Text & " welcome to tab one!"
        Label2.Text = TextBox1.Text & " welcome to tab two!"
        Label3.Text = TextBox1.Text & " welcome to tab three!"

        TabQuestionLoad()

    End Sub
    Protected Sub MultiTabButtons_Click(sender As Object, e As EventArgs) Handles Tab1Button.Click, Tab2Button.Click, Tab3Button.Click

        Dim buttonChosen As Button = sender

        ResetTabItems()
        buttonChosen.Enabled = False
        SetPanelDisable()

        Select Case (buttonChosen.ID)

            Case Tab1Button.ID
                buttonChosen.BackColor = Tab1Panel.BackColor
                buttonChosen.BorderColor = Tab1Panel.BackColor
                Tab1Panel.Visible = True

            Case Tab2Button.ID
                buttonChosen.BackColor = Tab2Panel.BackColor
                buttonChosen.BorderColor = Tab2Panel.BackColor
                Tab2Panel.Visible = True

            Case Tab3Button.ID

                buttonChosen.BackColor = Tab1Panel.BackColor
                buttonChosen.BorderColor = Tab3Panel.BackColor
                Tab3Panel.Visible = True


        End Select

        buttonChosen.ForeColor = Color.DarkGray
    End Sub

    Private Sub Tab3FirstQuestions()

        LabelInsideTab3.Text = QUESTION_ONE & TextBox1.Text & "?"

    End Sub

    Private Sub Tab3SecondQuestions()
        LabelInsideTab3.Text = QUESTION_TWO & TextBox1.Text & "?"
    End Sub


    Private Sub ResetTabItems()

        Tab1Button.Enabled = True
        Tab2Button.Enabled = True
        Tab3Button.Enabled = True


        Tab1Button.ForeColor = Color.Black
        Tab2Button.ForeColor = Color.Black
        Tab3Button.ForeColor = Color.Black


    End Sub

    Private Sub SetPanelDisable()

        Tab1Panel.Visible = False
        Tab2Panel.Visible = False
        Tab3Panel.Visible = False


    End Sub


    Private Sub TabQuestionLoad()

        ButtonInTab1.Visible = True
        TextBoxInTab1.Visible = True
        ButtonInTab2.Visible = True
        TextBoxInTab2.Visible = True
        LabelInsideTab3.Visible = True
        Tab3YesButton.Visible = True
        Tab3NoButton.Visible = True
        Tab3SecondQuestions()


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonInTab1_Click(sender As Object, e As EventArgs) Handles ButtonInTab1.Click
        Label1.Text += " Why did you move here from " + TextBoxInTab1.Text + "?"
        ButtonInTab1.Visible = False
        TextBoxInTab1.Visible = False
    End Sub
    Protected Sub ButtonInTab2_Click(sender As Object, e As EventArgs) Handles ButtonInTab2.Click
        Label2.Text += "    " & TextBoxInTab2.Text & ", hmm I think that author said, 'Tab B, or not Tab B, that is the question... wait it is Tab 2 not Tab B."
        TextBoxInTab2.Visible = False
        ButtonInTab2.Visible = False
    End Sub
    Protected Sub Tab3YesButton_Click(sender As Object, e As EventArgs) Handles Tab3YesButton.Click

        Label3.Text += " Ok, Ok, I believe you."
        Tab3YesButton.Visible = False
        Tab3NoButton.Visible = False

    End Sub
    Protected Sub Tab3NoButton_Click(sender As Object, e As EventArgs) Handles Tab3NoButton.Click
        Label3.Text += " Hah! I knew that was not your name!"
        Tab3YesButton.Visible = False
        Tab3NoButton.Visible = False
    End Sub
    Protected Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Button1.Visible = True
        TextBox1.Visible = True
        StartButton.Visible = False
        Tab1Button.Visible = True
        Tab2Button.Visible = True
        Tab3Button.Visible = True
        MultiTabButtons_Click(Tab1Button, e)
    End Sub
End Class
