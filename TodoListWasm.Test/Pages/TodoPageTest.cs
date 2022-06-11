using TodoListWasm.Pages;

public class TodoPageTest
{
    [Fact]
    public void ToDoListShouldIncrementWhenCheckAddTodo()
    {
        // Arrange
        using var ctx = new TestContext();
        var todoComponent = ctx.RenderComponent<Todo>();
        var newTodoInput = todoComponent.Find("#newTodoInput");
        var addTodoBtn = todoComponent.Find("#addTodoBtn");
        var todoTitle = todoComponent.Find("#todoTitle");
        // Act
        newTodoInput.Change("Do Breakfast!!");
        addTodoBtn.Click();

        // Assert
        todoTitle.MarkupMatches("<h3 id=\"todoTitle\">Todo (1)</h3>");
    }
}