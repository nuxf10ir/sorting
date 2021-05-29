$( function() {
	var $elem = $( "#sortable" );
	var rightOrder = ['def5', 'def3', 'def2', 'def1', 'def4'];
	$elem.sortable({
		axis: "y",
		forcePlaceholderSize: true,
		helper: "clone",
		update: function() {
			var currentOrder = $elem.sortable( "toArray" );
			var instance = $elem.sortable( "instance" );
			currentOrder.forEach(function(value, index) {
				var elem = instance.element.find('#'+value);
				elem.removeClass("green");
				if (value === rightOrder[index]) {
					elem.addClass("green");
				}
			})
		},
	});
	$elem.disableSelection();
} );
