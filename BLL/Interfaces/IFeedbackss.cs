﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IFeedbackss
    {
        bool Create(Feedback model);
        Feedback GetDatabyID(string id);
        List<Feedback> GetDataAll();
    }
}
