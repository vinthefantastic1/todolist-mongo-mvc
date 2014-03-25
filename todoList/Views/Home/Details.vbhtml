@ModelType todoitem
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
