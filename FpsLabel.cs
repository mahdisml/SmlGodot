using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Godot;

namespace firstPersonController.Scripts;

public partial class MyPlayer : Label
{
	private List<double> _fps = new List<double>();
	private double _exactFps = 0;

	public override void _Ready()
	{
		
	}

	
	public override void _Process(double delta)
	{
		_exactFps += 1 / delta;
		_fps.Add(1 / delta);
		
		if (_fps.Count > 60)
		{
			_exactFps = _exactFps / 60;
			Text = $"{_exactFps:0} min : {_fps.Min():0} max : {_fps.Max():0}";
			_exactFps = 0;
			_fps.Clear();
		}
	}
}
