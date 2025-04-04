namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Triana()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Triana()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Triana()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Triana()
	{
		Assert.AreEqual(3, Program.Subtract("5", "2"));
		Assert.AreEqual(5, Program.Subtract("10", "5"));
		Assert.AreEqual(1, Program.Subtract("5", "4"));
	}

	[TestMethod]
	public void Subtract_Invalid_Triana()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Triana()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Triana()
	{
		Assert.AreEqual(3, Program.Multiply("1", "3"));
		Assert.AreEqual(8, Program.Multiply("4", "2"));
		Assert.AreEqual(12, Program.Multiply("4", "3"));
	}

	[TestMethod]
	public void Multiply_Invalid_Triana()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Triana()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Triana()
	{
		Assert.AreEqual(2, Program.Divide("2", "1"));
		Assert.AreEqual(2, Program.Divide("4", "2"));
		Assert.AreEqual(3, Program.Divide("15", "5"));
	}

	[TestMethod]
	public void Divide_Invalid_Triana()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null_Triana()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Triana()
	{
		Assert.AreEqual(1, Program.Power("1", "2"));
		Assert.AreEqual(9, Program.Power("3", "2"));
		Assert.AreEqual(16, Program.Power("2", "4"));
	}

	[TestMethod]
	public void Power_Invalid_Triana()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null_Triana()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}

