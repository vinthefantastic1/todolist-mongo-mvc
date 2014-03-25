@ModelType IEnumerable(Of todoList.todoitem)
@Code
ViewData("Title") = "All Tasks"
End Code

<h2>@ViewData("Title")</h2>

<p>
    <a href="@Url.Action("Create")" class="btn btn-primary">Create New</a>
</p>
<table class="table table-condensed">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.completed)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.createdOn)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.completedOn)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.completed)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.createdOn)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.completedOn)
        </td>
         <td>
             <a href="@Url.Action("Edit",New With {.id = item.taskId})" class="btn btn-xs btn-primary">edit</a>
             |
             <a href="@Url.Action("Details", New With {.id = item.taskId})" class="btn btn-xs btn-warning">details</a>
             |
             <a href="@Url.Action("Delete", New With {.id = item.taskId})" class="btn btn-xs btn-danger">delete</a>
         </td>

    </tr>
Next

</table>
