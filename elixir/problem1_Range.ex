# Define the module. It must start with a capital letter
defmodule Problem1 do
	def solve() do
		# Use of the pipe forward 
		getMultiplesOf3And5 |> sumList
	end

	def getMultiplesOf3And5 do
		myList = []
		# TODO: this doesn't work
		Enum.each(1..9,
			fn(i) -> List.insert_at(myList, -1, i) end )
		myList
	end


	# The method sumList is overloaded and resolved with pattern matching.
	# If the method is called with a list that has a head and a tail, the 
	# first definition will be called and the vairables head and tail will
	# be bound.
	def sumList ([head | tail]) do
		head + sumList(tail)
	end

	def sumList ([]) do
		0
	end
end
