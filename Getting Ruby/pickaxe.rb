def say_name(name)
  "Good night, #{name.split('')}"
end
#puts say_name('mam')

name = 'name' #local variable
@name = 'name' #instance variable
#@@name  = 'name'  class variable
FEET_PER_MILE = 12 #constant

#Hashes
inst_section = {
  :cello =>'string',
  :clarinet =>'woodwind',
   :drum =>'percussion',
  :oboe =>'woodwind',
  :trumpet =>'brass',
  :violin =>'string',
}

#Control structures
today = Time.now
if today.saturday?
  #puts"Dochoresaroundthehouse"
elsif today.sunday?
  #puts"Relax"
else
  #puts"Gotowork"
end

#attr_reader and attr_accessor
class BookInStock
  attr_reader :isbn
  attr_accessor :price

  def initialize(isbn, price)
    @isbn = isbn
    @price = Float(price)
  end
end

book = BookInStock.new("el librito1", 15.22)
#puts "ISBN = #{book.isbn}"
#puts "Price = #{book.price}"
book.price = book.price - 0.80
#puts "New price = #{book.price}"
