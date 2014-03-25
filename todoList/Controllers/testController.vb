Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports todoList.Models

Namespace todoList
    Public Class testController
        Inherits System.Web.Mvc.Controller

        Private db As New todoListContext

        ' GET: /test/
        Function Index() As ActionResult
            Return View(db.todoitems.ToList())
        End Function

        ' GET: /test/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim todoitem As todoitem = db.todoitems.Find(id)
            If IsNothing(todoitem) Then
                Return HttpNotFound()
            End If
            Return View(todoitem)
        End Function

        ' GET: /test/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /test/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "id,taskId,description,completed,createdOn,completedOn")> ByVal todoitem As todoitem) As ActionResult
            If ModelState.IsValid Then
                db.todoitems.Add(todoitem)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(todoitem)
        End Function

        ' GET: /test/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim todoitem As todoitem = db.todoitems.Find(id)
            If IsNothing(todoitem) Then
                Return HttpNotFound()
            End If
            Return View(todoitem)
        End Function

        ' POST: /test/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "id,taskId,description,completed,createdOn,completedOn")> ByVal todoitem As todoitem) As ActionResult
            If ModelState.IsValid Then
                db.Entry(todoitem).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(todoitem)
        End Function

        ' GET: /test/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim todoitem As todoitem = db.todoitems.Find(id)
            If IsNothing(todoitem) Then
                Return HttpNotFound()
            End If
            Return View(todoitem)
        End Function

        ' POST: /test/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim todoitem As todoitem = db.todoitems.Find(id)
            db.todoitems.Remove(todoitem)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
