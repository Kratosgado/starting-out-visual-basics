' Displaying the square root of 2 in a dialog

Imports System.Windows.Forms ' namespace containing MessageBox

Module modDialogBox
    Sub main()

        ' calculate square root of 2
        Dim root As Double = Math.Sqrt(2)

        ' display result in a dialog
        MessageBox.Show("The square root of 2 is " & root,
            "The Square Root of 2")
    End Sub ' Main
End Module ' modDialogBoxj