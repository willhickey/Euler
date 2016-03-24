use strict;
my $file = 'names.txt';
open (IN, $file);
my $in = <IN>;

#print $names;
my @names = $in =~ m|"([^"]*)"|g;
@names = sort(@names);
my $counter = 1;
my $total = 0;
foreach my $name (@names)
{
	
	my @nameLetters = split('', $name);
	my $wordScore = 0;
	foreach my $let (@nameLetters)
	{
		my $value = ord($let)-64;
		print "$value $let\n";
		$wordScore = $wordScore+$value;
	}
	$wordScore = $wordScore*$counter;
	print "$counter:  $name\t\t$wordScore\n";
	$total = $total + $wordScore;
	#exit;
	$counter++;

}
print "Total:  $total\n";