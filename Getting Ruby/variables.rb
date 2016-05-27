person="Tim"
"The object in 'person' is a #{person.class}"
"The object has an id of #{person.object_id}"
"and a value of '#{person}'"

person1 = 'Tim'
person2 = person1.dup #creates a new string object
person1[0] = 'J'
person1 + " => The object has an id of #{person1.object_id}"
person2 + " => The object has an id of #{person2.object_id}"


a = [3.1416, 'TOMAS', nil]
a.shift #removes the first element
a.pop   #removes the last element

square = "some shape"
sum = 0
[1,2,3,4].each do |value; square|
  square = value*value
  sum += square
end

[1,2,3,4,5].each_with_index do |elmnt, index|
   "Value #{elmnt}, index #{index}"
end

["H","A","T"].collect { |x| x.succ } # =>["I","B","U"], succ increments the string value
[1,3,5,7].inject(:+)

a = [ 1, 3, "cat" ]
h = { dog: "canine", fox: "vulpine" }
enum_a = a.to_enum
enum_h = h.to_enum

enum_a.next #=> 1
enum_a.next #=> 3
enum_h.next #=> [:dog, "canine"]
enum_h.next #=> [:fox, "vulpine"]

result = []
"cat".split('').each_with_index{ |item, index| result << [item,index] } # => [["c", 0], ["a", 1], ["t", 2]]

def n_times(thing)
  lambda {|n| thing * n}
end

pl = n_times(23)
pl.call(2) # => 46
pm = n_times("Hola! ")
pm.call(3) # => "Hola! Hola! Hola! "

#Numbers 0x es hexa 0d es decimal 0 seguido por un numero es octal 
3.times { print "X " }
1.upto(5) { |i| print i, " " }
99.downto(95) { |i| print i , " " }
50.step(80,5) { |i| print i, " " }
