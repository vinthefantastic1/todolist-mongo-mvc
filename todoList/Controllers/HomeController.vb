Imports MongoDB.Bson
Imports MongoDB.Driver
Imports MongoDB.Driver.Builders
Imports MongoDB.Driver.Linq

Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports todoList.Models


Public Class HomeController
    Inherits System.Web.Mvc.Controller


    Dim connectionString As String = "mongodb://localhost"
    'Dim connectionString As String = "mongodb://192.168.1.10"
    Dim mongo As New MongoClient(connectionString)
    Dim mongoServer As MongoServer = mongo.GetServer
    Dim db As MongoDatabase = mongoServer.GetDatabase("todo2")
    Dim myColl As MongoCollection = db.GetCollection("todo2")

    Function test() As ActionResult
        Return View()

    End Function
    Function Index() As ActionResult

        Dim tdl As MongoCollection(Of todoitem)
        tdl = db.GetCollection(Of todoitem)("todo2")

        Dim vw = (From t In tdl Order By t.createdOn).ToList

        Return View(vw)
    End Function

    Function create() As ActionResult

        Dim tdl As New todoitem
        tdl.createdOn = Now

        Return View(tdl)
    End Function

    <HttpPost()>
 <ValidateAntiForgeryToken()>
    Function Create(<Bind(Include:="id,description,completed,createdOn,completedOn")> ByVal todoitem As todoitem) As ActionResult
        If ModelState.IsValid Then
            myColl.Insert(todoitem)
            Return RedirectToAction("Index")
        End If
        Return View(todoitem)
    End Function


    Function Details(ByVal id As String) As ActionResult
        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If

        Dim t As MongoCollection(Of todoitem)
        t = db.GetCollection(Of todoitem)("todo2")
        Try
            Dim vw = (From v In t Where v.taskId.Equals(id)).First
            Return View(vw)
        Catch ex As Exception
            Return HttpNotFound()
        End Try


    End Function

    Function Delete(ByVal id As String) As ActionResult
        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If

        Dim t As MongoCollection(Of todoitem)
        t = db.GetCollection(Of todoitem)("todo2")

        Try
            Dim vw = (From v In t Where v.taskId.Equals(id)).First
            Return View(vw)
        Catch ex As Exception
            Return HttpNotFound()
        End Try

    End Function

    <HttpPost()>
    <ActionName("Delete")>
    <ValidateAntiForgeryToken()>
    Function DeleteConfirmed(ByVal id As String) As ActionResult

        myColl.remove(Query.EQ("taskId", id))

        Return RedirectToAction("Index")
    End Function

    Function Edit(ByVal id As String) As ActionResult
        If IsNothing(id) Then
            Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        End If

        Dim t As MongoCollection(Of todoitem)
        t = db.GetCollection(Of todoitem)("todo2")
        Try
            Dim vw = (From v In t Where v.taskId.Equals(id)).First
            Return View(vw)
        Catch ex As Exception
            Return HttpNotFound()
        End Try
    End Function

    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(<Bind(Include:="id,taskId,description,completed,createdOn,completedOn")> ByVal todoitem As todoitem) As ActionResult


        ' this technically should work but for some reason it creates a new document instead of updating the old one.
        'myColl.Save(todoitem)

        ' so since we can't just "save" it, we have to do it the hard way...

        Dim query As New QueryDocument
        query.Set("taskId", todoitem.taskId)

        Dim update As New UpdateDocument
        update.Set("description", todoitem.description)
        update.Set("completed", todoitem.completed)
        update.Set("completedOn", todoitem.completedOn)
        update.Set("createdOn", todoitem.createdOn)
        update.Set("taskId", todoitem.taskId)


        Dim xx = myColl.Update(query, update)


        Return RedirectToAction("Index")
    End Function

    Function about2() As ActionResult
        Return PartialView("_about2")
    End Function


    Function About() As ActionResult
    
        Return View()
    End Function


End Class
