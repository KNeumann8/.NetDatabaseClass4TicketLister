using System;

public class Ticket
{
    private int ticketID;
    private string summary;
    private string status;
    private string priority;
    private string submitter;
    private string assinged;
    private string watching;

	public Ticket(int ticketID,string summary,string status, string priority, string submitter,string assinged,string watching)
	{
        this.ticketID = ticketID;
        this.summary = summary;
        this.status = status;
        this.priority = priority;
        this.submitter = submitter;
        this.assinged = assinged;
        this.watching = watching;
	}

    public string formatOut()
    {
        string output = ticketID + "," + summary + "," + status + "," + priority + "," + submitter + "," + assinged + ",";
        //If I need to make a future toString method I will use the following, for now it sits
        //for(int i = 0; i<watching.Length; i++)
        //{
        //    output += watching[i];
        //    if (i < watching.Length - 2) output += "|";
        //}
        output += watching; //Using for now because of changing string array to string
        return output;
    }

}
