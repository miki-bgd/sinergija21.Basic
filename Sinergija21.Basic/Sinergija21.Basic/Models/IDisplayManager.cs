﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sinergija21.Basic.Models
{
	public interface IDisplayManager
	{
		event Action Initialized;

		int DrawLine();

		int DrawSphere();

		int DrawCoordinateSystem();

		/// <summary>
		/// Rotates modela round Z axis (right-handed coordinate system 
		/// rotation goes counter-clockwise).
		/// </summary>
		void SetModelZRotation(int id, float angleDeg);
	}
}
