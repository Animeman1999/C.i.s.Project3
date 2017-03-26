'Jeffrey Martin
'Project 3 Tabs

'This Is the visual basic file used for the program. It Is a single page program used do demonstrate tabs.

Imports System.Drawing

Partial Class Default2
    Inherits System.Web.UI.Page

#Region "Variables"

    'CONSTANTS

    'Questons that can be used.
    Private Const QUESTION_ONE As String = "Are you sure your name is "
    Private Const QUESTION_TWO As String = "You look like a Fred to me, are you sure your name is "

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' After a user enters a name place data into the infromation label in each of the panels. Then call the function
    ''' that will enable all the buttons and textboxes used in each panel.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub EnterNameButton_Click(sender As Object, e As EventArgs) Handles EnterNameButton.Click

        'Validate somthing was entered.
        If NameTextBox.Text.Trim() <> "" Then

            InformationLabel1.Text = NameTextBox.Text & " welcome to tab one!"
            InformationLabel2.Text = NameTextBox.Text & " welcome to tab two!"
            InformationLabel3.Text = NameTextBox.Text & " welcome to tab three!"

            EnablePanelQuestionItems()

        Else

            MsgBox("Need to enter a name.", MsgBoxStyle.Information, "Name not entered")
            NameTextBox.Focus()

        End If


    End Sub

    ''' <summary>
    ''' Used to control how the tabs work.  
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub MultiTabButtons_Click(sender As Object, e As EventArgs) Handles Tab1Button.Click, Tab2Button.Click, Tab3Button.Click

        Dim tabChosen As Button = sender

        'The tabs are reset tab items to default value than the tab that was chose and the panels are set to disabled. 
        ResetTabItems()
        tabChosen.Enabled = False
        tabChosen.ForeColor = Color.DarkGray
        SetPanelDisable()

        'Enable the coresponding panel to the tab chosen
        Select Case (tabChosen.ID)

            Case Tab1Button.ID

                Tab1Panel.Visible = True

            Case Tab2Button.ID

                Tab2Panel.Visible = True

            Case Tab3Button.ID

                Tab3Panel.Visible = True


        End Select


    End Sub

    ''' <summary>
    ''' When the user enters where they came from, it is concatinated with a message then the Button and
    ''' Text box in the panel is disabled. 
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub ButtonInPanel1_Click(sender As Object, e As EventArgs) Handles ButtonInPanel1.Click

        'Validate somthing was entered.
        If TextBoxInPanel1.Text.Trim() <> "" Then

            InformationLabel1.Text += " Why did you move here from " + TextBoxInPanel1.Text + "?"
            ButtonInPanel1.Visible = False
            TextBoxInPanel1.Visible = False

        Else

            MsgBox("Need to enter where you moved from.", MsgBoxStyle.Information, "Area not entered")
            TextBoxInPanel1.Focus()

        End If



    End Sub

    ''' <summary>
    ''' When the user enters an authors namem it is concatinated with a message then the Button and
    ''' Text box in the panel is disabled. 
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub ButtonInPanel2_Click(sender As Object, e As EventArgs) Handles ButtonInPanel2.Click

        'Validate somthing was entered.
        If TextBoxInPanel2.Text.Trim() <> "" Then

            InformationLabel2.Text += "    " & TextBoxInPanel2.Text & ", hmm I think that author said, 'Tab B, or not Tab B, that is the question... wait it is Tab 2 not Tab B."
            TextBoxInPanel2.Visible = False
            ButtonInPanel2.Visible = False

        Else

            MsgBox("Need to enter a name of an author.", MsgBoxStyle.Information, "Author not entered")
            TextBoxInPanel2.Focus()

        End If

    End Sub

    ''' <summary>
    ''' When the user clicks yes, dispaly a message and disable the Yes and No button in the panel.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub Panel3YesButton_Click(sender As Object, e As EventArgs) Handles Panel3YesButton.Click

        InformationLabel3.Text += " Ok, Ok, I believe you."
        Panel3YesButton.Visible = False
        Panel3NoButton.Visible = False

    End Sub

    ''' <summary>
    ''' When the user clicks no, dispaly a message and disable the Yes and No button in the panel.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub Panel3NoButton_Click(sender As Object, e As EventArgs) Handles Panel3NoButton.Click

        InformationLabel3.Text += " Hah! I knew that was not your name!"
        Panel3YesButton.Visible = False
        Panel3NoButton.Visible = False

    End Sub

    ''' <summary>
    ''' This button starts up the display of the enter name button, textbox and the panel with tabs.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        EnterNameButton.Visible = True
        NameTextBox.Visible = True
        StartButton.Visible = False
        Tab1Button.Visible = True
        Tab2Button.Visible = True
        Tab3Button.Visible = True

        'Start with tab1 selected.
        MultiTabButtons_Click(Tab1Button, e)

    End Sub

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' Simply display a question into the label inside of panel 3.
    ''' </summary>
    Private Sub Tab3FirstQuestions()

        QuestionLabelInsidePanel3.Text = QUESTION_ONE & NameTextBox.Text & "?"

    End Sub

    ''' <summary>
    ''' Simply display a question into the label inside of panel 3.
    ''' </summary>
    Private Sub Tab3SecondQuestions()

        QuestionLabelInsidePanel3.Text = QUESTION_TWO & NameTextBox.Text & "?"

    End Sub

    ''' <summary>
    ''' Set all the tabs to enabled and text to black.
    ''' </summary>
    Private Sub ResetTabItems()

        Tab1Button.Enabled = True
        Tab2Button.Enabled = True
        Tab3Button.Enabled = True

        Tab1Button.ForeColor = Color.Black
        Tab2Button.ForeColor = Color.Black
        Tab3Button.ForeColor = Color.Black


    End Sub

    ''' <summary>
    ''' Set the panels to disabled.
    ''' </summary>
    Private Sub SetPanelDisable()

        Tab1Panel.Visible = False
        Tab2Panel.Visible = False
        Tab3Panel.Visible = False

    End Sub

    ''' <summary>
    ''' Enable all the question items on each panel to enabled. Select the Tab 3 
    ''' question by running the method.
    ''' </summary>
    Private Sub EnablePanelQuestionItems()

        ButtonInPanel1.Visible = True
        TextBoxInPanel1.Visible = True
        ButtonInPanel2.Visible = True
        TextBoxInPanel2.Visible = True
        QuestionLabelInsidePanel3.Visible = True
        Panel3YesButton.Visible = True
        Panel3NoButton.Visible = True
        Tab3SecondQuestions()

    End Sub

#End Region

End Class
