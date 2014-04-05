@ModelType IEnumerable(Of todoList.todoitem)
@Code
ViewData("Title") = "All Tasks"
End Code

<h2>@ViewData("Title")</h2>

<div class="text-danger" id="error">@viewdata("error")</div>

<style>
    input:focus {
        width: 350px;
    }
</style>

<p></p>
    <div class="row">
        <div class="col-xs-8">
            @Using Html.BeginForm("index", "home", FormMethod.Post, New With {.class = "form-inline"})
                @Html.TextArea("newtask", New With {.class = "form-control", .cols = "50"})
                    @<button type="submit" class="btn btn-primary">Create task</button>

            End Using
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

        <td>@If item.completed = True Then
            @<del>@Html.Raw(item.description)</del>
        Else
            @Html.Raw(item.description)
        End If
            
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.completed)
        </td>

    </tr>
Next

</table>




