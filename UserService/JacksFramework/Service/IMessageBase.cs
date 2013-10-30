using System;

namespace JacksFramework.Service
{
	public interface IMessageBase
	{
		Guid Id { get; set; }
		DateTime? Timestamp { get; set; }
	}
}
