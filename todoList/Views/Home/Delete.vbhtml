@ModelType todoitem
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete <span class="glyphicon glyphicon-remove"></h2>

<h3 class="text-danger">Are you sure you want to delete this?</h3>
<div>
    <h4>todoitem</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.completed)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.completed)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.createdOn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.createdOn)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.completedOn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.completedOn)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default btn-danger" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
