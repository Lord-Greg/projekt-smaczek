namespace DbModel.Patterns
{
	public record Result
	{
		public bool IsSuccess { get; init; }
		public string? ErrorMessage { get; }

		protected Result(bool isSuccess, string? errorMessage) { 
			IsSuccess = isSuccess;
			ErrorMessage = errorMessage;
		}

		public static Result Success() => new (true, null);
		public static Result Failure(string errorMessage) => new (false, errorMessage);
	}

	public record Result<T> : Result
	{
		public T Data { get; }

		private Result(T data) : base(true, null) => Data = data;

		public static implicit operator Result<T>(T data) => new(data);
	}
}
