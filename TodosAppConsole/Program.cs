
using System.Net.Http.Json;
using TodosAppConsole;

string url = "https://todosapi.kod.fun/api/TodoItems";

using (var client = new HttpClient())
{
    List<Todo> todos = await client.GetFromJsonAsync<List<Todo>>(url);

    foreach (Todo todo in todos)
    {
        string durum = todo.Done ? "Yapıldı" : "Yapılmadı";
        Console.WriteLine(todo.Id + ". " + todo.Title + " (" + durum + ")");
    }
}

Console.ReadKey();