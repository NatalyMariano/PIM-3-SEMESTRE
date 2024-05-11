public class ListaDeFeedback
{
    private static ListaDeFeedback instance;

    private List<(int id, int media)> feedbackList;

    private ListaDeFeedback()
    {
        feedbackList = new List<(int id, int media)>();
    }

    public static ListaDeFeedback Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ListaDeFeedback();
            }
            return instance;
        }
    }

    public List<(int id, int media)> FeedbackList
    {
        get { return feedbackList; }
    }

    // Método para adicionar feedback à lista
    public void AdicionarFeedback(int id, int media)
    {
        feedbackList.Add((id, media));
    }
}
