require 'minitest/autorun'
require_relative 'Movie'

class MovieTest < Minitest::Test

  def setup
    @movie = Movie.new({
        :title => 'Star wars',
        :genre => 'Science Fiction',
        :director => 'George Lucas',
        :release_date => '1997-05-25',
        :rotten_tomatoes => '93',
      })
  end

  def test_comedy?
    assert_equal false, @movie.comedy?
    @movie.genre = 'Comedy'
    assert_equal true, @movie.comedy?
  end

  def test_director
    assert_equal 'George Lucas', @movie.director
  end

  def test_genre
    assert_equal 'Science Fiction', @movie.genre
  end

  def test_release_date
    assert_equal Date.new(1997,5,25), @movie.release_date
  end

  def test_rotten_tomatoes
    assert_equal 93, @movie.rotten_tomatoes
  end

  def test_title
    assert_equal 'Star wars', @movie.title
  end

end
