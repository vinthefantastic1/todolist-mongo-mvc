Imports MongoDB.Bson
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Public Class todoitem

    <Key()>
    Property id As ObjectId
    'Property id As String
    Property taskId As String
    Property description As String
    Property completed As Boolean = False
    Property createdOn As Date
    Property completedOn As Date


    Public Sub New()
        id = ObjectId.GenerateNewId
        taskId = id.ToString
    End Sub

End Class
