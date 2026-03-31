using System;

public struct student
{
	private int ID;
	private string Name;
	private Test Score;
	pulic 

	public student(int id, string n,int m, int f)
	{
		ID = id;
		Name = n;
		Score =new Test(m,f);

		Count++;
	}
	public string Getstudent()
	{
		string str;
		str = "學生編號" + ID.ToString();
		str+= "\n學生姓名:" + Name;
		str += "\n期中考成績:" + Score.GetMid().ToString();
        str += "\n期末考成績:" + Score.GetFinal().ToString();
        str += "\n平均成績:" + Score.GetAvg().ToString();
		return str;



    }
}
