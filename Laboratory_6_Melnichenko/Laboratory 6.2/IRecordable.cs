﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab6_2 {
	public interface IRecordable : IMedia {
		void Record();
		void Pause();
		void Stop();
	}
}
