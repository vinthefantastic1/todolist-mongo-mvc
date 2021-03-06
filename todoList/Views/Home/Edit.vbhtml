﻿@ModelType todoitem
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit <span class="glyphicon glyphicon-edit"></span></h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>todoitem</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.id)
         @Html.HiddenFor(Function(model) model.taskId)


        <div class="form-group">
            @Html.LabelFor(Function(model) model.taskId, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @model.taskId
                @Html.ValidationMessageFor(Function(model) model.taskId)
            </div>
        </div>

        <div class="form-group">

            @Html.LabelFor(Function(model) model.description, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.TextAreaFor(Function(model) model.description, 5, 1000, New With {.class = "col-md-10 form-control"})
                @Html.ValidationMessageFor(Function(model) model.description)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.completed, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.completed)
                @Html.ValidationMessageFor(Function(model) model.completed)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.createdOn, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.createdOn)
                @Html.ValidationMessageFor(Function(model) model.createdOn)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.completedOn, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.completedOn)
                @Html.ValidationMessageFor(Function(model) model.completedOn)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-primary" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
