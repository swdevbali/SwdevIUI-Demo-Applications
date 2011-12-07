Imports System.Windows.Forms
Imports SwdevIUI


Public Class Config
    Public Shared defaultHome As UserControl
    Public Shared Sub init()
        Pages.m_pageFactoryHash.Add(AssemblyName(), New PersonalCapoeiraWorksheetPageFactory)
        Pages.add("home", AssemblyName() & ".HomePage")
        defaultHome = Pages.Item("home") 'homepage before login
        MainWindow.Text = Application.ProductName & " version " & Application.ProductVersion
    End Sub
    Public Shared Function AssemblyName() As String
        Return System.Reflection.Assembly.GetExecutingAssembly.GetName.Name()
    End Function
End Class
