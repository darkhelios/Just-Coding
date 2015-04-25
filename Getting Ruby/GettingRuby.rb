class Tale

	#Defining the constructor
	def initialize(author, genre, body)
		@author = author
		@genre = genre
		@tale_body = body
	end

	#Creating objects
	mermaid_tale =  Tale.new('unknwon', 'fairy_tale', 'once upon a time...')

	arraybook = ['The treasure island', 'Don Quixote']

	hashbooks = {
			'title' => 'Don Quixote',
			'author' => 'R.L. Stevenson',
			'genre' => 'Adventure'
	}		

	#Method to display part of the tale
	def tell part_of_tale
		start_index = @tale_body.index(part_to_be_told)
		print @tale_body\
		[start_index+part_to_be_told.length,@tale_body.length]
	end

	#Getter for author attributes
	def author
		@author
	end

	#Setter for author attribute
	def author= (newAuthor)
		@author = newAuthor
	end

	#Writing on file
	def write_to_file
		#Rescue exceptions
	begin
		File.open('tale','w'){|file|
			file.puts @author
			file.puts @genre
			file.puts @tale_body
		}
	rescue Exception => ex
		$stderr.print 'File open failed'
	end
	end

	#Reading from file
	def read_from_file
	File.readlines('tale').each{ |line|
		puts line
	}
	end

	#Printing title from a book on a hash defined
	puts hashbooks['title']

end