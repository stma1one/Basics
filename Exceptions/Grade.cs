using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions;

// מחלקה המייצגת ציון עם תכונה פרטית לשמירת הציון
public class Grade
{
	private int _score;//תכונה פרטית לשמירת הציון

	// מאפיין ציבורי לגישה לציון
	public int Score
	{
		get
		{
			return _score;
		}
		set 
		{
			if (value >= 0 && value <= 100) //בדיקה אם הציון בטווח תקין
				_score = value;
	
		}
	}
	
	/// <summary>
	/// בונה של מחלקת Grade עם ציון.
	/// </summary>
	/// <param name="score"></param>
	public Grade(int score)
	{
		Score = score; //הגדרת הציון באמצעות המאפיין
	}
}

