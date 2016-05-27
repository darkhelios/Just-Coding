class Card
  def initialize(suit:, rank:)
    @suit = suit
    @rank = case rank
    when :ace then 1
    when :jack then 11
    when :queen then 12
    when :king then 13
    when :high_ace then 14
    else rank
  end
  end

  def suit
    @suit
  end

  def rank
    @rank
  end

  def ==(other)
    rank == other.rank && suit == other.suit
  end
end

RSpec.describe 'a playing card' do
  it 'has a suit' do
    expect(Card.new(suit: :spades, rank: 4).suit).to eq(:spades)
  end

  it 'has a rank' do
    expect(Card.new(suit: :spades, rank: 4).rank).to eq(4)
  end

  it 'equal to itself' do
      subject = Card.new(suit: :spades, rank: 4)
      other = Card.new(suit: :spades, rank: 4)

      expect(subject).to eq(other)
  end

  it 'is not equal to a card of differing suit' do
      subject = Card.new(suit: :spades, rank: 4)
      other = Card.new(suit: :hearts, rank: 4)

      expect(subject).not_to eq(other)
  end

  it 'is not equal to a card of differing rank' do
      subject = Card.new(suit: :spades, rank: 4)
      other = Card.new(suit: :spades, rank: 5)

      expect(subject).not_to eq(other)
  end

  describe 'an ace' do
    it 'ranks lower than 2' do
      lower = Card.new(suit: :spades, rank: 1)
      higher = Card.new(suit: :spades, rank: 2)

      expect(lower.rank).to be < (higher.rank)
    end

    it 'ranks higher than a king' do
      lower = Card.new(suit: :spades, rank: :king)
      higher = Card.new(suit: :spades, rank: :high_ace)

      expect(lower.rank).to be < (higher.rank)
    end
  end

  describe 'a jack' do
    it 'ranks higher than 10' do
      lower = Card.new(suit: :spades, rank: 10)
      higher = Card.new(suit: :spades, rank: :jack)

      expect(lower.rank).to be < (higher.rank)
    end
  end

  describe 'a queen' do
    it 'ranks higher than a jack' do
      lower = Card.new(suit: :spades, rank: :jack)
      higher = Card.new(suit: :spades, rank: :queen)

      expect(lower.rank).to be < (higher.rank)
    end
  end

  describe 'a king' do
    it 'ranks higher than a queen' do
      lower = Card.new(suit: :spades, rank: :queen)
      higher = Card.new(suit: :spades, rank: :king)

      expect(lower.rank).to be < (higher.rank)
    end
  end
end
