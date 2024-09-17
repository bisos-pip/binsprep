#!/bisos/venv/py3/dev-bisos3/bin/python


from bisos.binsprep import interface

"""
This is the model that we are targetting:

---------
#!/usr/bin/env python

# dblock for name of the file comes here.

from bisos.binsprep import binsprep

ap = binsprep.aptPkg

aptPkgsList = [
    ap("djbdns"),
    ap("", instFn=someFunc),
]

binsprep.setup(
    aptPkgsList=aptPkgsList,
)

# dblock for the exec comes here.
------------
"""


interface.setFunc("FROM MINI")

__file__ = '/bisos/git/bxRepos/bisos-pip/binsprep/py3/bin/seedBinsPrep.cs'
with open(__file__) as f:
    exec(compile(f.read(), __file__, 'exec'))
