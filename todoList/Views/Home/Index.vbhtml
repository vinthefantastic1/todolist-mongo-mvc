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

<ol>
    
@For Each item In Model
         @<li>
           <a href="@Url.Action("Details", New With {.id = item.taskId})" >

        @If item.completed = True Then
            @<del>@Html.Raw(item.description)</del>
        Else
            @Html.Raw(item.description)
        End If
           </a>

    </li>
Next

</table>




