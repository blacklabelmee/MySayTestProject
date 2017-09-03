var loadingElement = $('.loadingElement');
var feedbackFormWrapper = $('.feedbackFormWrapper');
var feedbackWrapper = $('.feedBacks');

function ajaxStarted(data) {
    $('.feedbackForm :submit').addClass('disabled');//preventing multiple submit
    showLoadingElement();
}
function ajaxCompleted(data) {
    hideLoadingElement();
    $('.feedbackForm :submit').removeClass('disabled');
}

function ajaxSuccess(response) {
    //appending the new added feedback to the list.
    feedbackWrapper.append(
        '<div class="feedBack">' +
             '<p class="title">' +
                response.title +
             '</p>' +
             '<p class="desc">' +
                response.description +
             '</p>' +
             '<p class="feedBackDate text-muted">' +
                response.addingDate +
             '</p>' +
        '</div>').animate({ scrollTop: 9999 }, 'slow');


    //clearing the form
    $('.feedbackForm')[0].reset();

}

//codes for show the loading process in the ui
function showLoadingElement() {
    loadingElement.fadeIn();
    feedbackWrapper.animate({ 'opacity': 0.5 }, 'slow')
}
//codes for show the loading's end process in the ui
function hideLoadingElement() {
    loadingElement.fadeOut();
    feedbackWrapper.animate({ 'opacity': 1 }, 'slow')
}