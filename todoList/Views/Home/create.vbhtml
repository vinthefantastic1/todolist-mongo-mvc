@ModelType todolist.todoitem
@Code
    ViewData("Title") = "create"
End Code

<h2>create task</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>todolist</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.description, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.TextAreaFor(Function(model) model.description, 5, 900, New With {.style = "border:solid red 1px;"})
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
                <input type="submit" value="Create" class="btn btn-primary" />
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
