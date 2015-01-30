# Define the module. It must start with a capital letter
defmodule Problem1 do

	def solve() do
		getMultiplesOf3And5 |> sumList
	end

	def getMultiplesOf3And5 do
		#define a list
		# TODO - calculate the list
		#[ 3, 5, 6, 9 ]
		return makeList(3)
	end

	def makeList(9)
		[]
	end

	def makeList(num)
		if(rem(num, 3) == 0 or rem(num,5) == 0)
			output = [num] ++ makeList(num + 1)
		else
			output = makeList(num + 1)
		end		
		
		output
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
