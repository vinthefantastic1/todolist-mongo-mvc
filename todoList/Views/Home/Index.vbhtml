@ModelType IEnumerable(Of todoList.todoitem)
@Code
ViewData("Title") = "All Tasks"
End Code

<h2>@ViewData("Title")</h2>

<p></p>
    <div class="row">
        <div class="col-xs-8">
            <a href="@Url.Action("Create")" class="btn btn-primary">Create New</a>
            <textarea class="form-control"></textarea>
        </div>
        </div>

<table class="table table-condensed">
    <tr>
        <th></th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.completed)
        </th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
             <a href="@Url.Action("Details", New With {.id = item.taskId})" class="btn btn-xs btn-warning"><span class="glyphicon glyphicon-ok-sign"></span></a>
         </td>

        <td>    @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.completed)
        </td>

    </tr>
Next

</table>




