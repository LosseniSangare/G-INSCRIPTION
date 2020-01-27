Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Module mes_variables
    Public CN As New MySqlConnection("server=localhost; user id = root ;password= ;database =tp1_etudiant;")


    ' Public CN1 As New MySqlConnection("server=localhost; user id = root ;password= ;database =tp1_etudiant;")

    Public cmd As New MySqlCommand
    Public cmd1 As New MySqlCommand


    Public dr As MySqlDataReader
    Public dr1 As MySqlDataReader


    Public specialite As String
    Public niveau As String
    Public niveau_new As String
    Public annee As String
    Public annee_suivant As String
    Public Classe As String
    Public existe As Boolean = False
    Public compt As Integer = 0
    Public NCE As String
    Public selectioner As Integer = 0


    Public code_et As String
    Public code_class As Integer



End Module
