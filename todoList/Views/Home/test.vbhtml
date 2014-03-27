@Code
    ViewData("Title") = "test"
End Code

<h2>tes1t</h2>

<textarea class="form-control" rows="3"></textarea>

<div class="row">
    <div class="col-xs-2">
        <input type="text" class="form-control" placeholder=".col-xs-2">
    </div>
    <div class="col-xs-3">
        <input type="text" class="form-control" placeholder=".col-xs-3">
    </div>
    <div class="col-xs-4">
        <input type="text" class="form-control" placeholder=".col-xs-4">
    </div>
    <div class="col-xs-10">
        <input type="text" class="form-control" placeholder=".col-xs-10">
    </div>

    <div class="col-xs-4 col-md-4 col-sm-5">
        <textarea class="form-control"></textarea>
    </div>
</div>



    <form role="form" class="form-horizontal">
        <div class="row">
            <label class="col-xs-1" for="inputEmail1">Email</label>
            <div class="col-xs-4">
                <input type="email" class="form-control" id="inputEmail1" placeholder="Email">
            </div>
        </div>
        <div class="row">
            <label class="col-xs-1" for="inputPassword1">Password</label>
            <div class="col-xs-4">
                <input type="password" class="form-control" id="inputPassword1" placeholder="Password">
            </div>
        </div>
        <div class="row">
            <label class="col-md-4" for="TextArea">Text Area</label>
        </div>
        <div class="row">
            <div class="col-md-4">
                <textarea class="form-control" id="TextArea"></textarea>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <button type="submit" class="btn btn-default">Sign in</button>
            </div>
        </div>
    </form>


<form class="form-horizontal" role="form">
    <div class="form-group">
        <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
        <div class="col-sm-10">
            <input type="email" class="form-control" id="inputEmail3" placeholder="Email">
        </div>
    </div>
    <div class="form-group">
        <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
        <div class="col-sm-10">
            <input type="password" class="form-control" id="inputPassword3" placeholder="Password">
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <div class="checkbox">
                <label>
                    <input type="checkbox"> Remember me
                </label>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <button type="submit" class="btn btn-default">Sign in</button>
        </div>
    </div>
</form>

    <div class="row">
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
        <div class="col-md-1">.col-md-1</div>
    </div>
    <div class="row">
        <div class="col-md-8">.col-md-8</div>
        <div class="col-md-4">.col-md-4</div>
    </div>
    <div class="row">
        <div class="col-md-4">.col-md-4</div>
        <div class="col-md-4">.col-md-4</div>
        <div class="col-md-4">.col-md-4</div>
    </div>
    <div class="row">
        <div class="col-md-6">.col-md-6</div>
        <div class="col-md-6">.col-md-6</div>
    </div>


    <div class="row">
        <div class="col-xs-12 col-md-8">.col-xs-12 .col-md-8</div>
        <div class="col-xs-6 col-md-4">.col-xs-6 .col-md-4</div>
    </div>

    <!-- Columns start at 50% wide on mobile and bump up to 33.3% wide on desktop -->
    <div class="row">
        <div class="col-xs-6 col-md-4">.col-xs-6 .col-md-4</div>
        <div class="col-xs-6 col-md-4">.col-xs-6 .col-md-4</div>
        <div class="col-xs-6 col-md-4">.col-xs-6 .col-md-4</div>
    </div>

    <!-- Columns are always 50% wide, on mobile and desktop -->
    <div class="row">
        <div class="col-xs-6">.col-xs-6</div>
        <div class="col-xs-6">.col-xs-6</div>
    </div>


    <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-8">.col-xs-12 .col-sm-6 .col-md-8</div>
        <div class="col-xs-6 col-md-4">.col-xs-6 .col-md-4</div>
    </div>
    <div class="row">
        <div class="col-xs-6 col-sm-4">.col-xs-6 .col-sm-4</div>
        <div class="col-xs-6 col-sm-4">.col-xs-6 .col-sm-4</div>
        <!-- Optional: clear the XS cols if their content doesn't match in height -->
        <div class="clearfix visible-xs"></div>
        <div class="col-xs-6 col-sm-4">.col-xs-6 .col-sm-4</div>
    </div>


    <div class="row">
        <div class="col-xs-6 col-sm-3">.col-xs-6 .col-sm-3</div>
        <div class="col-xs-6 col-sm-3">.col-xs-6 .col-sm-3</div>

        <!-- Add the extra clearfix for only the required viewport -->
        <div class="clearfix visible-xs"></div>

        <div class="col-xs-6 col-sm-3">.col-xs-6 .col-sm-3</div>
        <div class="col-xs-6 col-sm-3">.col-xs-6 .col-sm-3</div>
    </div>

<hr />

<div class="container">
    <form role="form">
        <div class="row">
            <label class="col-xs-4" for="inputEmail1">Email</label>
            <div class="col-xs-8">
                <input type="email" class="form-control" id="inputEmail1" placeholder="Email">
            </div>
        </div>
        <div class="row">
            <label class="col-xs-4" for="inputPassword1">Password</label>
            <div class="col-xs-8">
                <input type="password" class="form-control" id="inputPassword1" placeholder="Password">
            </div>
        </div>
        <div class="row">
            <label class="col-xs-12" for="TextArea">Text Area</label>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <textarea class="form-control" id="TextArea"></textarea>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <button type="submit" class="btn btn-default">Sign in</button>
            </div>
        </div>
    </form>
</div>
