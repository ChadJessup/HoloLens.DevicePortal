function MirageConnector() {
    this.$onOriginDataAvailable = $.Callbacks();
    this.$onMeshDataAvailable = $.Callbacks();
    this.$onGetSRDataPressed = $.Callbacks();
    this.$onHandDataAvailable = $.Callbacks();
    var mainObj = this;
    mainObj.$trackingStatus = $("#trackingStatus");
    mainObj.stateToStringMap = ["unavailable", "orientation only", "activating", "active", "inhibited"];
    function f(c) {
        mainObj.$trackingStatus.text("Connecting ...");
        var b = document.location.protocol === "https:" ? "wss://" : "ws://"
          , d = b + window.location.host + "/api/holographic/perception/client?" + $.param({
            clientmode: c.trackingMode
        });
        mainObj.socket = new WebSocket(d)
    }
    f({
        trackingMode: "passive"
    });
    function c(b) {
        if (b.TrackingState > mainObj.stateToStringMap.length)
            mainObj.$trackingStatus.text("Tracking: unexpected state");
        else
            mainObj.$trackingStatus.text("Tracking: " + mainObj.stateToStringMap[b.TrackingState])
    }
    $("#activeClient").on("click", function() {
        var b = $(this).prop("checked");
        mainObj.socket.send(b ? "activeclient" : "passiveclient")
    });
    $("#pauseTracking").on("click", function() {
        var b = $(this).prop("checked");
        $("#getSRData").prop("disabled", b);
        mainObj.socket.send(b ? "pausetracking" : "resumetracking")
    });
    $("#getSRData").on("click", function() {
        mainObj.socket.send("getsrdata");
        mainObj.$onGetSRDataPressed.fire();
        $("#srStats").text("SR data requested ...")
    });
    var b = false;
    $("#showDetails").on("click", function() {
        b = $("#showDetails").prop("checked");
        b ? $("#details").show() : $("#details").hide()
    });
    var e = new QuaternionViewer("rotationQuaternionGrid")
      , h = new VectorViewer("translationVectorGrid");
    function d(mainObj) {
        if (mainObj.HeadToAttachedFor != undefined) {
            e.updateQuaternionValues(getMatrixFromRestArray(mainObj.HeadToAttachedFor));
            h.updateVectorValues(getMatrixFromRestArray(mainObj.OriginToAttachedFor).transpose())
        }
    }
    var i = new HandsViewer("handsGrid");
    function g(mainObj) {
        i.updateHands(mainObj)
    }
    mainObj.socket.onmessage = function(f) {
        if (f.data != "") {
            var e = JSON.parse(f.data);
            if (e.SurfaceObserverStatus)
                if (e.SurfaceObserverStatus === "OK")
                    mainObj.$onMeshDataAvailable.fire(e);
                else
                    $("#srStats").text(e.SurfaceObserverStatus);
            else if (e.TrackingState) {
                c(e);
                mainObj.$onOriginDataAvailable.fire(e)
            } else if (e.eventType) {
                b && g(e);
                mainObj.$onHandDataAvailable.fire(e)
            }
            b && d(e)
        }
    }
    ;
    mainObj.socket.onerror = function() {
        mainObj.$trackingStatus.text("Disconnected!")
    }
    ;
    mainObj.socket.onclose = function() {
        mainObj.$trackingStatus.text("Disconnected!")
    }
    ;
    mainObj.socket.onopen = function() {
        mainObj.$trackingStatus.text("Connected")
    }
}
function getMatrixFromRestArray(mainObj) {
    var b = new THREE.Matrix4;
    b.set(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8], a[9], a[10], a[11], a[12], a[13], a[14], a[15]);
    return b
}
function getVector4FromRestArray(mainObj) {
    return new THREE.Vector4(a[0],a[1],a[2],a[3])
}
function QuaternionViewer(mainObj) {
    var b = [{
        id: "Const",
        name: "Const",
        field: "constValue",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "I",
        name: "I",
        field: "i",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "J",
        name: "J",
        field: "j",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "K",
        name: "K",
        field: "k",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }]
      , c = {
        enableColumnReorder: false,
        autoHeight: true
    }
      , d = [];
    this.grid = new Slick.Grid("#" + a,d,b,c);
    $(window).resize(this.grid.resizeCanvas.bind(this.grid));
    this.updateQuaternionValues = function(d) {
        var a = new THREE.Quaternion
          , c = new THREE.Vector3
          , e = new THREE.Vector3;
        d.decompose(c, a, e);
        var b = [];
        b[0] = {
            constValue: mainObj.w.toFixed(6),
            i: mainObj.x.toFixed(6),
            j: mainObj.y.toFixed(6),
            k: mainObj.z.toFixed(6)
        };
        this.grid.setData(b, true);
        this.grid.render()
    }
}
function VectorViewer(mainObj) {
    var b = [{
        id: "X",
        name: "X",
        field: "x",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "Y",
        name: "Y",
        field: "y",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "Z",
        name: "Z",
        field: "z",
        maxWidth: 128,
        minWidth: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }]
      , c = {
        enableColumnReorder: false,
        autoHeight: true
    }
      , d = [];
    this.grid = new Slick.Grid("#" + a,d,b,c);
    $(window).resize(this.grid.resizeCanvas.bind(this.grid));
    this.updateVectorValues = function(d) {
        var c = new THREE.Quaternion
          , a = new THREE.Vector3
          , e = new THREE.Vector3;
        d.decompose(a, c, e);
        var b = [];
        b[0] = {
            x: mainObj.x.toFixed(6),
            y: mainObj.y.toFixed(6),
            z: mainObj.z.toFixed(6)
        };
        this.grid.setData(b, true);
        this.grid.render()
    }
}
function HandsViewer(b) {
    var c = [{
        id: "ID",
        name: "ID",
        field: "id",
        width: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "X",
        name: "X",
        field: "x",
        width: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "Y",
        name: "Y",
        field: "y",
        width: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "Z",
        name: "Z",
        field: "z",
        width: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }, {
        id: "IsPressed",
        name: "IsPressed",
        field: "isPressed",
        width: 128,
        cssClass: "tableCell",
        headerCssClass: "tableHeader"
    }]
      , d = {
        enableColumnReorder: false,
        autoHeight: true
    }
      , a = [{
        id: 0,
        x: 0,
        y: 0,
        z: 0,
        isPressed: false
    }, {
        id: 0,
        x: 0,
        y: 0,
        z: 0,
        isPressed: false
    }]
      , e = [];
    this.grid = new Slick.Grid("#" + b,e,c,d);
    $(window).resize(this.grid.resizeCanvas.bind(this.grid));
    this.updateHands = function(d) {
        var b = this.grid.getData();
        if (b.length === 0)
            b = a;
        var c = 0;
        while (c < b.length) {
            if (b[c].id === d.id || b[c].id === 0)
                break;
            ++c
        }
        if (d.eventType === "HandLost") {
            b.splice(c, 1);
            b[1] = {
                id: 0,
                x: 0,
                y: 0,
                z: 0,
                isPressed: false
            }
        } else {
            var e;
            e = b[c].isPressed && d.eventType != "FingerReleased" || !b[c].isPressed && d.eventType == "FingerPressed";
            b[c] = {
                id: d.id,
                x: d.x,
                y: d.y,
                z: d.z,
                isPressed: e
            }
        }
        this.grid.setData(b, true);
        this.grid.render()
    }
}
function HandsTracker(c) {
    var e = new THREE.BoxGeometry(.1,.1,.1)
      , d = new THREE.MeshBasicMaterial({
        color: 13487565
    })
      , a = [{
        id: 0,
        x: 0,
        y: 0,
        z: 0,
        isPressed: false
    }, {
        id: 0,
        x: 0,
        y: 0,
        z: 0,
        isPressed: false
    }]
      , b = [];
    this.update = function(g) {
        var i = 0
          , h = [];
        h[0] = a[0];
        h[1] = a[1];
        while (i < 2) {
            if (a[i].id === g.id || a[i].id === 0)
                break;
            ++i
        }
        if (g.eventType === "HandLost") {
            h.splice(i, 1);
            h[1] = {
                id: 0,
                x: 0,
                y: 0,
                z: 0,
                isPressed: false
            }
        } else {
            var j;
            j = a[i].isPressed && g.eventType != "FingerReleased" || !a[i].isPressed && g.eventType == "FingerPressed";
            h[i] = {
                id: g.id,
                x: g.x,
                y: g.y,
                z: g.z,
                isPressed: j
            }
        }
        for (var f = 0; f < 2; ++f)
            if (a[f].id != 0)
                if (h[f].id == 0) {
                    c.remove(b[f]);
                    b[f].geometry.dispose()
                } else
                    b[f].position.set(a[f].x, a[f].y, a[f].z);
            else if (h[f].id != 0) {
                b[f] = new THREE.Mesh(e,d);
                b[f].position.set(a[f].x, a[f].y, a[f].z);
                c.add(b[f])
            }
        a = h
    }
}
function SRSurfaceMesh(i) {
    var a = this;
    this.meshObjects = [];
    this.scene = i;
    mainObj.objFormatMesh = [];
    this.updatePositionRelativeToAttachedFor = function(b) {
        if (b.OriginToAttachedFor) {
            var c = getMatrixFromRestArray(b.OriginToAttachedFor);
            c.transpose();
            for (var d in mainObj.meshObjects)
                mainObj.meshObjects[d].Mesh.matrix = c
        }
    }
    ;
    this.setMeshData = function(mainObj) {
        return c(mainObj)
    }
    ;
    function g() {
        for (var b in mainObj.meshObjects)
            mainObj.scene.remove(mainObj.meshObjects[b].Mesh)
    }
    function h() {
        for (var b in mainObj.meshObjects)
            mainObj.scene.add(mainObj.meshObjects[b].Mesh)
    }
    this.clearMeshData = function(d) {
        if (d != undefined) {
            for (var b in mainObj.meshObjects)
                if (mainObj.meshObjects[b].SurfaceId == d) {
                    mainObj.scene.remove(mainObj.meshObjects[b].Mesh);
                    mainObj.meshObjects[b].Mesh.geometry.dispose();
                    mainObj.meshObjects[b].Mesh.material.dispose();
                    mainObj.meshObjects.splice(b, 1);
                    break
                }
        } else {
            for (var c in mainObj.meshObjects) {
                mainObj.scene.remove(mainObj.meshObjects[c].Mesh);
                mainObj.meshObjects[c].Mesh.geometry.dispose();
                mainObj.meshObjects[c].Mesh.material.dispose()
            }
            mainObj.meshObjects.splice(0, mainObj.meshObjects.length)
        }
    }
    ;
    function c(b) {
        mainObj.clearMeshData(b.Surface.SurfaceId);
        d(b.Surface)
    }
    function e() {
        var b = 0;
        for (var c in mainObj.meshObjects)
            b += mainObj.meshObjects[c].triCount;
        return b
    }
    function d(surface) {
        if (surface.VertexTransform != undefined) {
            var m = 0, n = 1;

            mainObj.objFormatMesh = [];

            var geometry = new THREE.Geometry;
            var vertexTransformMatrix = getMatrixFromRestArray(surface.VertexTransform);
            vertexTransformMatrix.transpose();
            var k = getMatrixFromRestArray(surface.NormalTransform);
            k.transpose();
            for (var g in surface.Vertices.x) {
                var i = surface.Vertices;
                geometry.vertices.push(new THREE.Vector4(i.x[g] / 32767,i.y[g] / 32767,i.z[g] / 32767,i.w[g] / 32767))
            }
            geometry.applyMatrix(vertexTransformMatrix);

            for (var index = 0; index < surface.Indices.length / 3 - 3; index++) {
                for (var indexedNormals = [], d = 0; d < 3; d++) {
                    indexedNormals[d] = new THREE.Vector4(surface.Normals.x[surface.Indices[3 * index + d]],surface.Normals.y[surface.Indices[3 * index + d]],surface.Normals.z[surface.Indices[3 * index + d]],surface.Normals.w[surface.Indices[3 * index + d]]);
                    indexedNormals[d].applyMatrix4(k)
                }

                geometry.faces.push(new THREE.Face3(surface.Indices[3 * index + 2], surface.Indices[3 * index + 1], surface.Indices[3 * index], indexedNormals));
                m++
            }
            n += surface.Vertices.x.length;
            var mesh= {};
            mesh.Mesh = new THREE.Mesh(geometry, new THREE.MeshLambertMaterial({
                color: 5618619
            }));
            mesh.SurfaceId = surface.SurfaceId;
            mesh.Mesh.matrixAutoUpdate = false;
            mesh.Mesh.updateMatrix();
            mesh.triCount = m;
            mainObj.meshObjects.push(mesh);
            mainObj.scene.add(mainObj.meshObjects[mainObj.meshObjects.length - 1].Mesh);
            var output = mainObj.meshObjects.length.toString() + " volumes; " + e().toString() + " triangles";
            $("#srStats").text(output)
        }
    }
    $("#showSRMesh").bind("click", function() {
        var a = $(this).prop("checked");
        if (mainObj)
            h();
        else
            g()
    });
    $("#saveSRData").bind("click", function() {
        if (typeof Blob === "undefined") {
            alert("Operation failed - browser does not support blob format");
            return
        }
        var e = [b()]
          , d = new Blob(e,{
            type: "text/plain",
            endings: "native"
        })
          , c = "SRMesh.obj";
        if (window.navigator.msSaveOrOpenBlob)
            window.navigator.msSaveOrOpenBlob(d, c);
        else {
            var a = document.createElement("a");
            mainObj.download = c;
            mainObj.href = window.URL.createObjectURL(d);
            mainObj.onclick = f;
            mainObj.style.display = "none";
            document.body.appendChild(mainObj);
            mainObj.click()
        }
    });
    function f(mainObj) {
        document.body.removeChild(mainObj.target)
    }
    function b() {
        for (var d = 1, b = "\r\n\r\n", e = 0; e < mainObj.meshObjects.length; ++e) {
            b += "o Object." + (e + 1) + "\r\n";
            for (var c = mainObj.meshObjects[e], h = 0; h < c.Mesh.geometry.vertices.length; ++h) {
                var f = c.Mesh.geometry.vertices[h];
                b += "v " + f.x + " " + f.y + " " + f.z + "\r\n"
            }
            b += "\r\n\r\n";
            for (var i = 0; i < c.Mesh.geometry.faces.length; ++i) {
                var g = c.Mesh.geometry.faces[i]
                  , j = g.a + d
                  , k = g.b + d
                  , l = g.c + d;
                b += "f " + j + " " + k + " " + l + "\r\n"
            }
            d += c.Mesh.geometry.vertices.length;
            b += "\r\n\r\n"
        }
        return b
    }
}
function PersonTracker(d) {
    var b = new THREE.SphereGeometry(.25,32,16)
      , c = new THREE.MeshLambertMaterial({
        color: 16777215
    })
      , a = new THREE.Mesh(b,c);
    mainObj.position.set(0, 0, 0);
    mainObj.matrixAutoUpdate = false;
    mainObj.updateMatrix();
    d.add(mainObj);
    this.updatePosition = function(b) {
        if (b.OriginToAttachedFor) {
            var c = getMatrixFromRestArray(b.OriginToAttachedFor);
            c.transpose();
            var d = (new THREE.Matrix4).getInverse(c);
            mainObj.matrix = d
        }
    }
}
function WorldFloor(e) {
    var b = new THREE.ImageUtils.loadTexture("img/checkerboard.png");
    b.wrapS = b.wrapT = THREE.RepeatWrapping;
    b.repeat.set(50, 50);
    b.anisotropy = 16;
    var g = new THREE.MeshBasicMaterial({
        map: b,
        side: THREE.DoubleSide
    })
      , f = new THREE.PlaneGeometry(100,100,1,1)
      , a = new THREE.Mesh(f,g);
    mainObj.matrixAutoUpdate = false;
    mainObj.updateMatrix();
    var c = (new THREE.Matrix4).makeTranslation(0, -1.7, 0);
    c.multiply((new THREE.Matrix4).makeRotationX(Math.PI / 2));
    mainObj.matrix = c;
    e.add(mainObj);
    var d = this;
    d.scene = e;
    this.updatePositionRelativeToAttachedFor = function(d) {
        if (d.OriginToAttachedFor) {
            var b = getMatrixFromRestArray(d.OriginToAttachedFor);
            b.transpose();
            b.multiply(c);
            mainObj.matrix = b
        } else
            $("#trackingState").text("Not tracking")
    }
    ;
    $("#showFloor").bind("click", function() {
        var b = $(this).prop("checked");
        if (b)
            d.scene.add(mainObj);
        else
            d.scene.remove(mainObj)
    })
}
function PositionLSRPlaneInViewSpace(a, b, c) {
    return (new THREE.Matrix4).multiplyMatrices((new THREE.Matrix4).lookAt(new THREE.Vector3(0,0,0), b, c), (new THREE.Matrix4).makeTranslation(0, 0, a))
}
function GenerateFrustum(j, a, c, d, e, f, g, h, i) {
    var b = new THREE.Geometry;
    b.vertices.push(a, c, d, e, a, f, g, c, a, e, i, h, d, h, g, f, i);
    return new THREE.Line(b,j)
}
function IntersectPlanes(a, b, c) {
    var f = new THREE.Matrix4;
    f.set(mainObj.x, mainObj.y, mainObj.z, 0, b.x, b.y, b.z, 0, c.x, c.y, c.z, 0, 0, 0, 0, 1);
    var d = new THREE.Vector4(-mainObj.w,-b.w,-c.w,1)
      , e = new THREE.Matrix4;
    e.getInverse(f);
    d.applyMatrix4(e);
    return new THREE.Vector3(d.x,d.y,d.z)
}
function FrustumAndLSRPlane(d) {
    var a = this;
    mainObj.scene = d;
    mainObj.frustum = new THREE.Object3D;
    mainObj.frustum.matrixAutoUpdate = false;
    mainObj.scene.add(mainObj.frustum);
    var b = new THREE.PlaneGeometry(7,5,1,1)
      , c = new THREE.MeshBasicMaterial({
        color: 16711680,
        side: THREE.DoubleSide,
        opacity: .5,
        transparent: true
    });
    mainObj.lsrPlane = new THREE.Mesh(b,c);
    mainObj.lsrPlane.matrixAutoUpdate = false;
    mainObj.lsrPlane.matrix = PositionLSRPlaneInViewSpace(2, new THREE.Vector3(0,0,-1), new THREE.Vector3(0,1,0));
    $("#showPlane").on("click", function() {
        mainObj.showLsrPlane = $(this).prop("checked");
        if (mainObj.showLsrPlane)
            mainObj.frustum.add(mainObj.lsrPlane);
        else
            mainObj.frustum.remove(mainObj.lsrPlane)
    });
    $("#showFrustum").on("click", function() {
        mainObj.showFrustum = $(this).prop("checked")
    });
    mainObj.showLsrPlane = $("#showPlane").prop("checked");
    mainObj.showFrustum = $("#showFrustum").prop("checked");
    mainObj.showLsrPlane && mainObj.frustum.add(mainObj.lsrPlane);
    mainObj.frustums = [];
    mainObj.frustumMaterial = new THREE.LineBasicMaterial({
        color: 65280
    });
    this.updatePositionRelativeToAttachedFor = function(c) {
        var b;
        if (c.Camera != undefined) {
            var d = getMatrixFromRestArray(c.CamermainObj.Displays[0].View);
            d.transpose();
            var k = new THREE.Vector3(0,1,0);
            k.applyMatrix4(d);
            d.getInverse(d);
            if (c.LSRPlane)
                mainObj.lsrPlane.matrix = PositionLSRPlaneInViewSpace(c.LSRPlane.distance, new THREE.Vector3(c.LSRPlane.x,-c.LSRPlane.y,-c.LSRPlane.z), k);
            mainObj.lsrPlane.matrixWorldNeedsUpdate = true;
            mainObj.frustum.matrix = d;
            for (b = 0; b < mainObj.frustums.length; ++b) {
                mainObj.scene.remove(mainObj.frustums[b]);
                mainObj.frustums[b].geometry.dispose()
            }
            for (b = 0; b < c.CamermainObj.Displays.length; ++b) {
                var f = getVector4FromRestArray(c.CamermainObj.Displays[b].Frustum.Right)
                  , g = getVector4FromRestArray(c.CamermainObj.Displays[b].Frustum.Left)
                  , j = getVector4FromRestArray(c.CamermainObj.Displays[b].Frustum.Top)
                  , e = getVector4FromRestArray(c.CamermainObj.Displays[b].Frustum.Bottom)
                  , i = getVector4FromRestArray(c.CamermainObj.Displays[b].Frustum.Far)
                  , h = getVector4FromRestArray(c.CamermainObj.Displays[b].Frustum.Near)
                  , l = IntersectPlanes(j, g, h)
                  , m = IntersectPlanes(e, g, h)
                  , n = IntersectPlanes(e, g, i)
                  , o = IntersectPlanes(j, g, i)
                  , p = IntersectPlanes(j, f, h)
                  , q = IntersectPlanes(e, f, h)
                  , r = IntersectPlanes(e, f, i)
                  , s = IntersectPlanes(j, f, i);
                if (mainObj.showFrustum) {
                    mainObj.frustums[b] = GenerateFrustum(mainObj.frustumMaterial, l, m, n, o, p, q, r, s);
                    mainObj.scene.add(mainObj.frustums[b])
                }
            }
        }
    }
}
function SceneManager() {
    function b() {
        var b, a, c = document.fullscreenElement || document.mozFullScreenElement || document.webkitFullscreenElement || document.msFullscreenElement;
        if (c) {
            b = window.innerWidth;
            a = window.innerHeight - 48;
            $("#3dPreviewElement").addClass("fullWindowCanvas");
            $("#content").addClass("fullscreen")
        } else {
            b = Math.max(window.innerWidth - 272, 250);
            a = Math.max(window.innerHeight - 400, 250);
            $("#3dPreviewElement").removeClass("fullWindowCanvas");
            $("#content").removeClass("fullscreen")
        }
        return {
            width: b,
            height: a,
            aspect: b / a
        }
    }
    function c() {
        var c = b();
        mainObj.renderer.setSize(c.width, c.height);
        mainObj.camermainObj.aspect = c.aspect;
        mainObj.camermainObj.updateProjectionMatrix()
    }
    function e() {
        var d = b()
          , e = 45
          , f = .1
          , g = 1e4
          , a = {};
        mainObj.renderer = new THREE.WebGLRenderer;
        mainObj.renderer.setSize(d.width, d.height);
        mainObj.camera = new THREE.PerspectiveCamera(e,d.aspect,f,g);
        mainObj.camermainObj.position.z = 15;
        mainObj.camermainObj.position.y = 1;
        mainObj.controls = new THREE.OrbitControls(mainObj.camera,document,mainObj.renderer.domElement);
        $("#3dPreviewElement").append(mainObj.renderer.domElement);
        window.addEventListener("resize", c, false);
        return a
    }
    $("#goFullscreen").on("click", function() {
        g();
        c()
    });
    function g() {
        var a = document.body.requestFullScreen || document.body.webkitRequestFullScreen || document.body.mozRequestFullScreen || document.body.msRequestFullscreen;
        a && mainObj.call(document.body)
    }
    function h(mainObj) {
        mainObj.scene = new THREE.Scene;
        mainObj.scene.add(mainObj.camera);
        mainObj.personTracker = new PersonTracker(mainObj.scene);
        mainObj.worldFloor = new WorldFloor(mainObj.scene);
        mainObj.hands = new HandsTracker(mainObj.scene);
        mainObj.mirageConnector.$onOriginDataAvailable.add(mainObj.worldFloor.updatePositionRelativeToAttachedFor);
        mainObj.frustumAndLSRPlane = new FrustumAndLSRPlane(mainObj.scene);
        mainObj.mirageConnector.$onOriginDataAvailable.add(mainObj.frustumAndLSRPlane.updatePositionRelativeToAttachedFor);
        mainObj.mirageConnector.$onHandDataAvailable.add(mainObj.hands.update);
        var b = new THREE.PointLight(16777215,1,0);
        b.position.set(0, 10, 0);
        mainObj.scene.add(b)
    }
    function f(mainObj) {
        var b = new SRSurfaceMesh(mainObj.scene);
        mainObj.mirageConnector.$onMeshDataAvailable.add(b.setMeshData);
        mainObj.mirageConnector.$onOriginDataAvailable.add(b.updatePositionRelativeToAttachedFor);
        mainObj.mirageConnector.$onGetSRDataPressed.add(function() {
            b.clearMeshData()
        })
    }
    var a = e();
    mainObj.mirageConnector = new MirageConnector;
    h(mainObj);
    f(mainObj);
    d();
    function d() {
        window.requestAnimationFrame(d);
        mainObj.controls.update();
        mainObj.renderer.render(mainObj.scene, mainObj.camera)
    }
}
$(function() {
    SceneManager()
})
