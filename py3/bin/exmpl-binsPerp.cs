#!/usr/bin/env python

# dblock for name of the file comes here.

from bisos.binsprep import binsprep
ap = binsprep.aptPkg

aptPkgsList = [
    ap("djbdns"),
    ap("facter"),
    # ap("", instFn=someFunc),
]

binsprep.setup(
    aptPkgsList=aptPkgsList,
)

__file__ = '/bisos/git/bxRepos/bisos-pip/binsprep/py3/bin/seedBinsPrep.cs'
with open(__file__) as f:
    exec(compile(f.read(), __file__, 'exec'))
