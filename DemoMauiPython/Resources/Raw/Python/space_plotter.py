import matplotlib.pyplot as plt
from astropy.time import Time
from sunpy.coordinates import get_body_heliographic_stonyhurst

from io import BytesIO
from collections.abc import Buffer

face_color = '#FFFFFF'


def set_theme(background_color: str) -> None:
    global face_color
    face_color = background_color


def plot_earth_and_planet(planet: str) -> Buffer:
    obstime = Time.now()
    planet_list = ['earth', planet, 'sun']
    planet_coord = [get_body_heliographic_stonyhurst(
        this_planet, time=obstime) for this_planet in planet_list]

    fig = plt.figure(figsize=(5, 5), facecolor=face_color)
    ax = fig.add_subplot(projection='polar')
    ax.set_facecolor(face_color)
    for this_planet, this_coord in zip(planet_list, planet_coord):
        ax.plot(this_coord.lon.to('rad'), this_coord.radius, 'o', label=this_planet)
    ax.legend()

    plt.show()
    outstream = BytesIO()
    plt.savefig(outstream, format='png', dpi=300)
    return outstream.getbuffer()
