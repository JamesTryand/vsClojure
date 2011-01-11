﻿using System.Collections.Generic;

namespace ClojureExtension.Editor.InputHandling
{
	public interface ITextBufferAdapter
	{
		string GetText(int startPosition);
		int Length { get; }
		void SetText(string text);
		List<string> GetSelectedLines();
		void ReplaceSelectedLines(List<string> newLines);
	}
}