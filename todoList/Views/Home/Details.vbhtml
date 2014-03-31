@ModelType todoitem
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details <span class="glyphicon glyphicon-ok-sign"></h2>

<div>
    <h4>todoitem</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.taskId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.taskId)
        </dd>

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
</div>
<p>
    <a href="@Url.Action("Edit", New With {.id = Model.taskId})" class="btn btn-xs btn-primary"><span class="glyphicon glyphicon-edit"></span></a>

    <a href="@Url.Action("Delete", New With {.id = Model.taskId})" class="btn btn-xs btn-danger"><span class="glyphicon glyphicon-remove"></span></a> 
    @Html.ActionLink("Back to List", "Index")
</p>

